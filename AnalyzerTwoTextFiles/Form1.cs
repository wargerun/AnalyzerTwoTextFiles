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

        private void btn_generation_Click(object sender, EventArgs e)
        {
            WriteToFile();
            listView1.Clear();
            List<Line> file1 = GetLines("File1.txt");
            List<Line> file2 = GetLines("File2.txt");
            List<Line> resultLines = CheckLines(file1, file2);
            foreach (var line in resultLines)
            {
                if (line.Type == Line.LineType.Unchanged)
                {
                    ListViewItem li = new ListViewItem();
                    li.ForeColor = Color.Green;
                    li.Text = line.Text;
                    listView1.Items.Add(li);
                }
                else if (line.Type == Line.LineType.Added)
                {
                    ListViewItem li = new ListViewItem();
                    li.ForeColor = Color.Yellow;
                    li.Text = line.Text;
                    listView1.Items.Add(li);
                }
                else
                {
                    ListViewItem li = new ListViewItem();
                    li.ForeColor = Color.Red;
                    li.Text = line.Text;
                    listView1.Items.Add(li);
                }
            }
        }

        private List<Line> CheckLines(List<Line> file1, List<Line> file2)
        {
            var exceptOriginLines = file1.Except(file2, new LineComparer());
            foreach (var line in exceptOriginLines)
            {
                line.Type = Line.LineType.Deleted;
            }

            //все строки которых нет в оригинальном файле
            var exceptOtherLines = file2.Except(file1, new LineComparer());
            foreach (var line in exceptOtherLines)
            {
                line.Type = Line.LineType.Added;
            }

            //объединенная последовательность (без повторений)
            var unionLines = file1.Union(file2, new LineComparer());

            return unionLines.ToList();
        }

        private static List<Line> GetLines(string file)
        {
            List<Line> result = new List<Line>();

            try
            {
                foreach (var line in File.ReadAllLines(file))
                {
                    result.Add(new Line { Text = line });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Чтение {file} c ошибкой: {ex.Message}");
            }

            return result;
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
    }
}
