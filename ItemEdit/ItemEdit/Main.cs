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
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

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
        private string transPath = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();

            redo:
            path = System.Environment.CurrentDirectory + @"\user\mods\EmuTarkov-AllItemsExamined-1.0.0\db\items";
            transPath = System.Environment.CurrentDirectory + @"\user\mods\EmuTarkov-LocaleCh-1.0.0\db\locales\ch\templates";
            if (!Directory.Exists(path))
            {
                if (DialogResult.OK == fbd.ShowDialog())
                {
                    string basepath = fbd.SelectedPath;
                    path = Path.Combine(basepath, @"user\mods\EmuTarkov-AllItemsExamined-1.0.0\db\items");
                    transPath = Path.Combine(basepath, @"user\mods\EmuTarkov-LocaleCh-1.0.0\db\locales\ch\templates");
                }
            }

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
    }
}