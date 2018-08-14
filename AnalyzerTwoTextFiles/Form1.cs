using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalyzerTwoTextFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> file1 = new List<string>();
        List<string> file2 = new List<string>();
        private void btn_generation_Click(object sender, EventArgs e)
        {
            GetFile1();
            WriteToFile();
            GetFile2();
            listView1.Clear();
            for (int i = 0; i < file1.Count; i++)
            {
                for (int j = 0; j < file2.Count; j++)
                {
                    // Удаленные строки показываются красным цветом, добавленные - желтым, неизмененные - зеленым.
                    if (file1[i] == file2[j])// НЕ измененая строка - зеленая
                    {
                        ListViewItem li = new ListViewItem();
                        li.ForeColor = Color.Green;
                        li.Text = file1[i];
                        listView1.Items.Add(li);
                        break;
                    }
                    if (file1[i] != file2[j]) // Удаленные строки показываются красным цветом,
                    {
                        ListViewItem li = new ListViewItem();
                        li.ForeColor = Color.Red;
                        li.Text = file1[i];
                        listView1.Items.Add(li);
                        break;
                    }
                    //else if ...// добавленные - желтым,
                }
            }
        }

        private List<string> GetFile1()
        {
            file1.Clear();
            using (StreamReader sr = new StreamReader("File1.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    string arStr;
                    arStr = "";
                    for (int i = 0; i<s.Length;i++)
                    {
                        arStr += s[i] + " ";
                    }
                    file1.Add(arStr);
                }
                return file1;
            }
        }
        private void WriteToFile()
        {
            using (FileStream fstream = new FileStream("file2.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fstream))
                {
                    string strfile2 = textBox1.Text;
                    fstream.Seek(0, SeekOrigin.End);
                    sw.WriteLine(textBox1.Text);
                }
            }
        }
        private List<string> GetFile2()
        {
            file2.Clear();
            using (StreamReader sr = new StreamReader("File2.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    string arStr;
                    arStr = "";
                    for (int i = 0; i < s.Length; i++)
                    {
                        arStr += s[i] + " ";
                    }
                    file2.Add(arStr);
                }
                return file2;
            }
        }
    }
}
