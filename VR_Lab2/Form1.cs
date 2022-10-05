using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace VR_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ProcessFile(files[0]);
        }

        private void ProcessFile(string path)
        {
            fileStatus_label.Text = "Выбран файл: " + System.IO.Path.GetFileName(path);

            string[,] input;
            int len;


            try
            {
                var n = System.IO.File.ReadLines(path).First().Split(new char[] { ' ' }).Length;
                input = new string[n, n];
                len = n;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            input_textBox.Text = "";


            using (FileStream f = File.OpenRead(path))
            using (StreamReader reader = new StreamReader(f))
            {

                string str = reader.ReadLine();
                int j = 0;
                while (str != null)
                {
                    input_textBox.Text += str + Environment.NewLine;
                    var splited = str.Split(new char[] { ' ' });
                    for (int i = 0; i < splited.Length; i++)
                    {
                        input[j, i] = splited[i];
                    }

                    j++;
                    str = reader.ReadLine();
                }
            }

            var z = ZigzagScan(input, len);
            single_textBox.Text = String.Join(" ", z);
            RLE_textBox.Text = RLE(z);

            string textToWrite = "";
            textToWrite += "Исходный массив: " + Environment.NewLine + input_textBox.Text + Environment.NewLine;
            textToWrite += "Одномерный массив: " + single_textBox.Text + Environment.NewLine;
            textToWrite += "RLE : " + RLE_textBox.Text;

            File.WriteAllText("output.txt", textToWrite);
            Process.Start("output.txt");
            result_label.Text += "Результат сохранен в output.txt";
        }

        private string[] ZigzagScan(string[,] input, int n)
        {
            List<string> result = new List<string>();
            result.Add(input[0, 0]);
            int x = 0, y = 1;
            bool isDown = true;
            while (result.Count < n * n)
            {
                result.Add(input[x, y]);
                if (isDown)
                {
                    if (x + 1 < n && y - 1 >= 0)
                    {
                        x++;
                        y--;
                    }
                    else
                    {
                        if (x + 1 < n)
                        {
                            x++;
                        }
                        else
                        {
                            y++;
                        }
                        isDown = false;

                    }
                }
                else
                {
                    if (x - 1 >= 0 && y + 1 < n)
                    {
                        x--;
                        y++;
                    }
                    else
                    {
                        if (y + 1 < n)
                        {
                            y++;
                        }
                        else
                        {
                            x++;
                        }
                        isDown = true;
                    }
                }
            }
            return result.ToArray();
        }

        private string RLE(string[] input)
        {
            string text = string.Join("", input);
            string output = "";

            int count = 0;

            char currentSybmol = text[0];

            foreach (char symbol in text)
            {
                if (symbol == currentSybmol)
                    count++;
                else
                {
                    output += count.ToString() + currentSybmol;
                    currentSybmol = symbol;
                    count = 1;
                }
            }

            output += count.ToString() + currentSybmol;
            return output;
        }

        private void openFile_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileStatus_label.Text = "Файл: " + openFileDialog.FileName;
                ProcessFile(openFileDialog.FileName);
            }
        }


    }
}
