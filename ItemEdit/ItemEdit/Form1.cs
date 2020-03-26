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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string path = "";
        private string[] files;
        private SortedDictionary<string, Item> sortedItems = new SortedDictionary<string, Item>();
        private List<ListBoxItem> cacheItems = new List<ListBoxItem>();
        private void Form1_Load(object sender, EventArgs e)
        {
            path = System.Environment.CurrentDirectory + @"\user\mods\EmuTarkov-AllItemsExamined-1.0.0\db\items";
            if (!Directory.Exists(path))
            {
                var fbd = new FolderBrowserDialog();
                if (DialogResult.OK == fbd.ShowDialog())
                {
                    string basepath = fbd.SelectedPath;
                    path = Path.Combine(basepath, @"user\mods\EmuTarkov-AllItemsExamined-1.0.0\db\items");
                }
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
                sortedItems.Add(file, item);
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
                if (sortedItems[sortedItemsKey]._name.Contains(text))
                {
                    ListBoxItem listBoxItem = new ListBoxItem();
                    listBoxItem.FileName = sortedItemsKey;
                    listBoxItem.Text = sortedItems[sortedItemsKey]._name;
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
                 
                System.Diagnostics.Process.Start(((ListBoxItem)listBox1.SelectedItem).FileName);//双引号内填你想打开的文件路径

            }
            else
            {
                listBox1.SelectedIndex = -1;//不做任何操作，将ListBox的选中项取消
            }
        }
    }
}
