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
using System.Text.RegularExpressions;

namespace ICA11_RegexDictionary
{
    public partial class ICA11_RegexDictionary : Form
    {
        private Dictionary<string, int> _wordDic = new Dictionary<string, int>();

        public ICA11_RegexDictionary()
        {
            InitializeComponent();
        }

        private void B_LoadFile_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == OFD_WordFile.ShowDialog())
            {
                string filePath, rawText;

                filePath = OFD_WordFile.FileName;

                try
                {
                    rawText = File.ReadAllText(filePath);
                    //rawText.Replace(new char[] { }, ' ');
                    //List<string> wordList = new List<string>(rawText.Split(new char[] { '\r', '\n', ' ', '(', ')', ',', '.', '!', ';', ':', '*' }, StringSplitOptions.RemoveEmptyEntries));
                    List<string> wordList = new List<string>(Regex.Split(rawText, @"[^\w\d-']"));
                    wordList.ForEach(word => word.Trim());
                    wordList.RemoveAll(word => word == "");
                    
                    foreach (string word in wordList)
                    {
                        if (!_wordDic.ContainsKey(word))
                        {
                            _wordDic.Add(word, 1);
                        }
                        else
                        {
                            _wordDic[word]++;
                        }
                    }

                    _wordDic = _wordDic.OrderBy(word => word.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                    PopulateListView();

                }
                catch
                {
                    Console.WriteLine("Error reading file.");
                }
            }
        }

        private void B_SortCount_Click(object sender, EventArgs e)
        {
            _wordDic = _wordDic.OrderBy(word => word.Value).ThenBy(word => word.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            PopulateListView();
        }

        private void B_SortLength_Click(object sender, EventArgs e)
        {
            _wordDic = _wordDic.OrderByDescending(word => word.Key.Length).ThenBy(word => word.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            PopulateListView();
        }

        private void B_RemoveWords_Click(object sender, EventArgs e)
        {
            //_wordDic.Where(word => CheckNum(word));
            _wordDic = _wordDic.Where(CheckNum).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            PopulateListView();
        }

        private void PopulateListView()
        {
            LV_Words.Items.Clear();
            foreach (KeyValuePair<string, int> kvp in _wordDic )
            {
                ListViewItem lvi = LV_Words.Items.Add(kvp.Key);
                lvi.SubItems.Add(kvp.Value.ToString());                
            }
        }

        private bool CheckNum(KeyValuePair<string, int> kvp)
        {
            foreach (char kChar in kvp.Key)
            {
                if (Char.IsDigit(kChar))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
