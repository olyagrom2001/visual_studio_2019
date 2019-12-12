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
using System.Diagnostics;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public List<string> List { get; set; } = new List<string>();

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "Файлы *.txt|*.txt"
            };
            fileDialog.ShowDialog();

            if (fileDialog.FileName.Length == 0)
            {
                return;
            }

            Stopwatch time = new Stopwatch();
            time.Start();

            string text = File.ReadAllText(fileDialog.FileName);

            foreach (var word in text.Split())
            {
                if (!List.Contains(word))
                {
                    List.Add(word);
                }
            }

            time.Stop();

            Double result = time.Elapsed.TotalMilliseconds;
            ReadingTime.Text = result.ToString();
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            Stopwatch time = new Stopwatch();
            time.Start();

            foreach (string word in List)
            {
                if (word.Contains(textBox2.Text))
                {
                    WordList.Items.Add(textBox2.Text);
                    break;
                }
            }

            time.Stop();

            Double result = time.Elapsed.TotalMilliseconds;
            Search.Text = result.ToString();
        }
    }
}
