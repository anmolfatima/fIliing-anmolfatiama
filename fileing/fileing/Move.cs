using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Move : Form
    {
        public Move()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");

            comboBox4.Items.Add("C:\\");
            comboBox4.Items.Add("D:\\");
            comboBox4.Items.Add("E:\\");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo df in d)
            {
                comboBox2.Items.Add(df);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string spath = comboBox1.Text + comboBox2.Text + "\\";
            FileInfo info = new FileInfo(spath);
            FileInfo[] f = info.Directory.GetFiles();
            foreach (FileInfo inf in f)
            {
                comboBox3.Items.Add(inf);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox4.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo df in d)
            {
                comboBox5.Items.Add(df);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fspath = comboBox1.Text + comboBox2.Text + "\\" + comboBox3.Text;
            string fpath = comboBox4.Text + comboBox5.Text + "\\" + textBox1.Text;
            try
            {
                if (!File.Exists(fpath))
                {
                    File.Move(fspath, fpath);
                    MessageBox.Show("File is Moved");
                }
                else
                {
                    MessageBox.Show("File NOt Moved");
                }
            }
            catch (DuplicateNameException de)
            {
                MessageBox.Show(" plz write another name");

            }
            catch (Exception E)
            {
                MessageBox.Show("Something was wrong");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fililing fi = new Fililing();
            fi.Show();
        }

        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fililing fi = new Fililing();
            fi.Show();
           
        }

        private void copyFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Copy f1 = new Copy();
            f1.Show();
        }

        private void moveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Move f2 = new Move();
            f2.Show();
        }

        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete f3 = new Delete();
            f3.Show();
        }

        private void readFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReadFile f4 = new ReadFile();
            f4.Show();
        }

        private void writeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WriteFile f5 = new WriteFile();
            f5.Show();
        }

        private void fileStreamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileStream f6 = new FileStream();
            f6.Show();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Text = comboBox3.Text + "...";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
