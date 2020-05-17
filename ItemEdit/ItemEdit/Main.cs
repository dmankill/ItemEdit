using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ItemEdit.Models;
using ItemEdit.Models.profiles;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using Item = ItemEdit.Models.Item;
using Quest = ItemEdit.Models.Quest;

namespace ItemEdit
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private string path = "";
        private string[] files;
        private SortedDictionary<string, Item> sortedItems = new SortedDictionary<string, Item>();
        private List<ListBoxItem> cacheItems = new List<ListBoxItem>();
        private List<string> soundList = new List<string>();
        private Dictionary<string, string> transCh = new Dictionary<string, string>();
        private string basepath;
        private string transPath = "";
        private string configPath = "";
        private GameConfig gameConfig;
        private string ProfilePath = @"user\profiles\";
        private string tranquestpath = @"user\mods\EmuTarkov-LocaleCh-1.0.0\db\locales\ch\quest";
        private string enquesttransPath = @"db\locales\en\quest";
        private string orgLocalePath = @"dev\input\prod.escapefromtarkov.com.client.locale.ch.txt";

        private string moddir = @"user\mods\";
        private PropLocale propLocale;
        private Dictionary<string, Character> charList = new Dictionary<string, Character>(10);
        private Dictionary<string, Quest> questdic_ch = new Dictionary<string, Quest>();
        private Dictionary<string, Quest> questdic_en = new Dictionary<string, Quest>();
        private Dictionary<string, ModsConfigJson> mods = new Dictionary<string, ModsConfigJson>();
        private SysConfig sysConfig;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("config.json"))
            {
                var conf = File.ReadAllText("config.json");
                sysConfig = JsonConvert.DeserializeObject<SysConfig>(conf);
                basepath = sysConfig.DefaultPath;
            }
            else
            {
                sysConfig = new SysConfig();
            }
            
            var fbd = new FolderBrowserDialog();

            redo:
            basepath = Directory.Exists(basepath) ? basepath : System.Environment.CurrentDirectory;
            path = $"{basepath}\\user\\mods\\EmuTarkov-AllItemsExamined-1.0.0\\db\\items";
            transPath = $"{basepath}\\user\\mods\\EmuTarkov-LocaleCh-1.0.0\\db\\locales\\ch\\templates";
            configPath = $"{basepath}\\user\\configs";
            if (!Directory.Exists(path))
            {
                if (DialogResult.OK == fbd.ShowDialog())
                {
                    basepath = fbd.SelectedPath;
                    path = Path.Combine(basepath, @"user\mods\EmuTarkov-AllItemsExamined-1.0.0\db\items");
                    transPath = Path.Combine(basepath, @"user\mods\EmuTarkov-LocaleCh-1.0.0\db\locales\ch\templates");
                    configPath = Path.Combine(basepath, @"user\configs");
                    ProfilePath = Path.Combine(basepath, ProfilePath);
                    tranquestpath = Path.Combine(basepath, tranquestpath);
                    enquesttransPath = Path.Combine(basepath, enquesttransPath);
                    orgLocalePath = Path.Combine(basepath, orgLocalePath);
                }
                else
                {
                    this.Close();
                    return;
                }
            }

            txt_base_path.Text = basepath;
            sysConfig.DefaultPath = basepath;
            var cng = JsonConvert.SerializeObject(sysConfig);
            File.WriteAllText("config.json", cng, Encoding.UTF8);
            if (!Directory.Exists(path))
            {
                goto redo;
            }

            files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                var stream = File.OpenText(file);
                string json = stream.ReadToEnd();
                Item item = JsonConvert.DeserializeObject<Item>(json);
                if (item._props == null)
                {
                    continue;
                }

                if (item._props.ItemSound != null && !soundList.Contains(item._props.ItemSound))
                {
                    soundList.Add(item._props.ItemSound);
                }

                sortedItems.Add(file, item);
            }

            comboBox1.BeginUpdate();
            comboBox1.Items.AddRange(soundList.ToArray());
            comboBox1.EndUpdate();
            if (File.Exists(configPath + @"\gameplay.json"))
            {
                string gameConfigString = File.ReadAllText(configPath + @"\gameplay.json");
                gameConfig = JsonConvert.DeserializeObject<GameConfig>(gameConfigString);
                NUDUsec.Value = gameConfig.bots.pmcUsecChance;
                NUDpmc.Value = gameConfig.bots.pmcSpawnChance;
            }

            if (Directory.Exists(ProfilePath))
            {
                string[] profiles = Directory.GetDirectories(ProfilePath);

                if (profiles != null && profiles.Length > 0)
                {
                    cb_profile_list.BeginUpdate();
                    cb_profile_list.Items.Add("选择一个账号");
                    foreach (var profile in profiles)
                    {
                        var fileName = Path.Combine(profile, "character.json");
                        if (File.Exists(fileName))
                        {
                            var ch = JsonConvert.DeserializeObject<Character>(File.ReadAllText(fileName),
                                new JsonSerializerSettings()
                                {
                                    Error = ((o, args) =>
                                    {
                                        // args.ErrorContext.Handled = true;
                                    }),
                                    FloatParseHandling = FloatParseHandling.Decimal
                                });
                            charList.Add(ch.aid, ch);
                            cb_profile_list.Items.Add(new {Text = ch.Info.Nickname, Value = ch.aid});
                            cb_profile_list.DisplayMember = "Text";
                            cb_profile_list.ValueMember = "Value";
                        }
                    }

                    cb_profile_list.EndUpdate();
                }
            }

            if (Directory.Exists(tranquestpath))
            {
                var questPaths = Directory.GetFiles(tranquestpath);
                if (questPaths != null && questPaths.Length > 0)
                {
                    foreach (var questPath in questPaths)
                    {
                        if (File.Exists(questPath))
                        {
                            var quest1 = JsonConvert.DeserializeObject<Quest>(File.ReadAllText(questPath));
                            questdic_ch.Add(Path.GetFileName(questPath), quest1);
                        }
                    }
                }
            }

            if (Directory.Exists(enquesttransPath))
            {
                var questPaths = Directory.GetFiles(enquesttransPath);
                if (questPaths != null && questPaths.Length > 0)
                {
                    foreach (var questPath in questPaths)
                    {
                        if (File.Exists(questPath))
                        {
                            var quest1 = JsonConvert.DeserializeObject<Quest>(File.ReadAllText(questPath));
                            questdic_en.Add(Path.GetFileName(questPath), quest1);
                        }
                    }
                }
            }

            if (File.Exists(orgLocalePath))
            {
                propLocale = JsonConvert.DeserializeObject<PropLocale>(File.ReadAllText(orgLocalePath));
            }

            moddir = Path.Combine(basepath, moddir);
            if (Directory.Exists(moddir))
            {
                var dirs = Directory.GetDirectories(moddir);
                cbx_modlist.BeginUpdate();
                foreach (var dir in dirs)
                {

                    string config = Path.Combine(dir, "mod.config.json");
                    if (File.Exists(config))
                    {
                        string tempfile = File.ReadAllText(config);
                        ModsConfigJson configJson = JsonConvert.DeserializeObject<ModsConfigJson>(tempfile);
                        mods.Add(configJson.name, configJson);
                        cbx_modlist.Items.Add(new {configJson.name, value = config, cdir = dir});
                    }
                    
                }

                cbx_modlist.DisplayMember = "name";
                cbx_modlist.ValueMember = "value";
                cbx_modlist.EndUpdate();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var o = (TextBox) sender;
            var text = o.Text;
            if (text.Length > 1)
            {
                FindText(text);
            }
        }

        private void FindText(string text)
        {
            List<int> indexs = new List<int>();
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            cacheItems.Clear();

            foreach (var sortedItemsKey in sortedItems.Keys)
            {
                if (sortedItems[sortedItemsKey]._name.ToLower().Contains(text.ToLower()))
                {
                    ListBoxItem listBoxItem = new ListBoxItem();
                    listBoxItem.FileName = sortedItemsKey;
                    string name = GetTransName(sortedItemsKey);
                    listBoxItem.Text = name;
                    cacheItems.Add(listBoxItem);
                    listBox1.Items.Add(listBoxItem);
                }
            }

            listBox1.DisplayMember = "Text";

            listBox1.EndUpdate();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            if (text.Length > 1)
            {
                FindText(text);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                System.Diagnostics.Process.Start(((ListBoxItem) listBox1.SelectedItem).FileName); //双引号内填你想打开的文件路径
            }
            else
            {
                listBox1.SelectedIndex = -1; //不做任何操作，将ListBox的选中项取消
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private string GetTransName(string key)
        {
            string name;
            string fileName = Path.GetFileName(key);
            string transFilePath = Path.Combine(transPath, fileName);
            if (File.Exists(transFilePath))
            {
                string transString = File.OpenText(transFilePath).ReadToEnd();
                var transItem = JsonConvert.DeserializeObject<TransItem>(transString);
                name = transItem.Name;
            }
            else
            {
                name = sortedItems[key]._name;
            }

            return name;
        }

        private Quest GetQuest(string name)
        {
            if (questdic_ch.ContainsKey(name))
            {
                return questdic_ch[name];
            }
            else if (questdic_en.ContainsKey(name))
            {
                return questdic_en[name];
            }
            else
            {
                return new Quest();
            }
        }

        private string GetQuestName(string name)
        {
            if (propLocale.data.quest.ContainsKey(name))
            {
                return propLocale.data.quest[name].name;
            }
            else
            {
                return "";
            }
        }

        private string GetQuestDesc(string name)
        {
            var desck = propLocale.data.quest[name].description;
            if (propLocale.data.mail.ContainsKey(desck))
            {
                return propLocale.data.mail[desck];
            }

            return "";
        }

        private string GetQuestCoditions(string name)
        {
            var codi = propLocale.data.quest[name].conditions;
            var text = "";
            if (codi != null)
                foreach (var cs in codi)
                {
                    text += cs.Value + "\r\n";
                }

            return text;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var val = comboBox1.SelectedItem?.ToString();

            if (val != null)
            {
                listBox1.BeginUpdate();
                listBox1.Items.Clear();
                foreach (var sortedItem in sortedItems)
                {
                    if (sortedItem.Value._props.ItemSound == val)
                    {
                        string name = GetTransName(sortedItem.Key);

                        var lb = new ListBoxItem()
                        {
                            FileName = sortedItem.Key,
                            Text = name
                        };
                        cacheItems.Add(lb);
                        listBox1.Items.Add(lb);
                    }
                }

                listBox1.DisplayMember = "Text";
                listBox1.EndUpdate();
            }
        }

        private void btnSaveBOTRefPr_Click(object sender, EventArgs e)
        {
            gameConfig.bots.pmcUsecChance = (int) NUDUsec.Value;
            gameConfig.bots.pmcSpawnChance = (int) NUDpmc.Value;
            string gameConfigString = JsonConvert.SerializeObject(gameConfig, Formatting.Indented);
            File.WriteAllText(configPath + @"\gameplay.json", gameConfigString);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            var dirName = cb_profile_list.Text;
            var profileDir = Path.Combine(ProfilePath, dirName);
            var characterFilePath = Path.Combine(profileDir, "character.json");
            if (File.Exists(characterFilePath))
            {
                var charString = File.ReadAllText(characterFilePath);
                Character ch = JsonConvert.DeserializeObject<Character>(charString);
                List_Task.BeginUpdate();
                foreach (var chQuest in ch.Quests)
                {
                    List_Task.Items.Add(new {chQuest.qid, qname = GetTransName(chQuest.qid), chQuest.status});
                }

                List_Task.EndUpdate();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
        }

        private void cb_profile_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cb_profile_list.SelectedItem.GetType().GetProperty("Value")
                .GetValue(cb_profile_list.SelectedItem).ToString();
            var ch = charList[value];
            List_Task.BeginUpdate();
            List_Task.Items.Clear();
            foreach (var quest in ch.Quests)
            {
                if (quest.status.ToLower() == "started")
                    List_Task.Items.Add(new
                    {
                        Text = GetQuestName(quest.qid),
                        Status = quest.status,
                        Id = quest.qid
                    });
            }

            List_Task.DisplayMember = "Text";
            List_Task.ValueMember = "Id";
            List_Task.EndUpdate();
        }

        private void List_Task_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (dynamic) List_Task.SelectedItem;
            lblTaskName.Text = GetQuestName(item.Id);
            lbltaskdesc.Text = GetQuestDesc(item.Id);
            lbl_codition.Text = GetQuestCoditions(item.Id);
        }

        private void List_Task_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = (Dictionary<string, object>) List_Task.SelectedItem;
            var id = item["Id"];
        }

        private void TSMI_avaviableforsuccess_Click(object sender, EventArgs e)
        {
            var item = (dynamic) List_Task.SelectedItem;
            DoIt(1, item.Id.ToString());
        }

        private void TSMI_Success_Click(object sender, EventArgs e)
        {
            var item = (dynamic) List_Task.SelectedItem;
            DoIt(2, item.Id.ToString());
        }

        private void TSMI_Cancel_Click(object sender, EventArgs e)
        {
            CMS_ListTask.Hide();
        }

        private void DoIt(int type, string id)
        {
            string status = "Started";
            if (type == 1)
            {
                status = "AvailableForFinish";
            }
            else if (type == 2)
            {
                status = "Success";
            }

            var item = cb_profile_list.SelectedItem as dynamic;
            string aid = item.Value;
            var p = charList[aid];
            for (var index = 0; index < p.Quests.Length; index++)
            {
                if (p.Quests[index].qid == id)
                {
                    p.Quests[index].status = status;
                }
            }

            var path = Path.Combine(ProfilePath, aid);
            if (Directory.Exists(path))
            {
                var cpath = Path.Combine(path, "character.json");
                if (File.Exists(cpath))
                {
                    var backpath = Path.Combine(path,
                        $"character.{DateTime.Now:yyyyMMddHHmmss}.json");
                    File.Copy(cpath, backpath);
                    File.WriteAllText(cpath, JsonConvert.SerializeObject(p, Formatting.Indented,
                        new JsonSerializerSettings()
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        }));
                    charList[aid] = p;
                    cb_profile_list_SelectedIndexChanged(cb_profile_list, null);
                    MessageBox.Show("修改并保存成功");
                }
            }
        }

        private void List_Task_MouseUp(object sender, MouseEventArgs e)
        {
            int posindex = List_Task.IndexFromPoint(new Point(e.X, e.Y));
            List_Task.ContextMenuStrip = null;
            if (posindex >= 0 && posindex < List_Task.Items.Count)
            {
                List_Task.SelectedIndex = posindex;
            }

            if (e.Button == MouseButtons.Right)
            {
                CMS_ListTask.Show(List_Task, new Point(e.X, e.Y));
            }

            List_Task.Refresh();
        }

        private void Main_MouseHover(object sender, EventArgs e)
        {
        }

        private void cb_items_list_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_sel_base_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_base_path.Text = fbd.SelectedPath;
            }
        }

        private void btn_sel_dis_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = basepath;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_dis_path.Text = fbd.SelectedPath;
            }
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            string basepath = txt_base_path.Text;
            string dispath = txt_dis_path.Text;
            string abspath = txt_abs_path_list.Text;
            string[] abspaths = abspath.Split(new[] {'\r','\n'}, StringSplitOptions.RemoveEmptyEntries);
            abspaths.AsParallel().ForAll((src) =>
            {
                string tempp = Path.Combine(basepath, src);
                string filename = src.Split(new[] {'\\'}).Last();
                string temdp = Path.Combine(dispath, filename);
                if (File.Exists(tempp))
                {
                    if (Directory.Exists(dispath))
                    {
                        File.Copy(tempp, temdp);
                    }
                }
            });
        }

        private void btnSaveMod_Click(object sender, EventArgs e)
        {
            var item = cbx_modlist.SelectedItem as dynamic;
            if (item != null && item.name != null)
            {
                var modName = item.name;
                var txt = nud_MaxStackCount.Text;
                var max = int.Parse(txt);
                var cdir = item.cdir;
                if (max > 0)
                {
                    ModsConfigJson conf = mods[modName];
                    if (conf.db.ContainsKey("items"))
                    {
                        foreach (var itemKey in conf.db["items"])
                        {
                            
                            var tmp = Path.Combine(cdir, itemKey.Value.ToString());
                            string tmpCtx = File.ReadAllText(tmp);
                            Dictionary<string, object> itemObj =
                                JsonConvert.DeserializeObject<Dictionary<string, object>>(tmpCtx);
                            var jo = itemObj["_props"] as JObject;
                            jo["StackMaxSize"] = max;
                            itemObj["_props"] = jo;
                            tmpCtx = JsonConvert.SerializeObject(itemObj);
                            File.WriteAllText(tmp, tmpCtx, Encoding.UTF8);

                        }

                        MessageBox.Show("ok");
                    } 
                }
            }
        }

        private void btn_clear_cache_Click(object sender, EventArgs e)
        {
            string cachepath = Path.Combine(basepath, @"user\cache");
            if (Directory.Exists(cachepath))
            {
                Directory.Delete(cachepath, true);
                MessageBox.Show("delete ok");
            }
        }
    }
}