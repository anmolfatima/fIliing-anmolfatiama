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
    public partial class Fililing : Form
    {
        public Fililing()
        {
            InitializeComponent();
        }

        private void Fililing_Load(object sender, EventArgs e)
        {
            this.panel1.Hide();
            comboBox1.Items.Add("C:\\");
            comboBox1.Items.Add("D:\\");
            comboBox1.Items.Add("E:\\");

            comboBox3.Items.Add("C:\\");
            comboBox3.Items.Add("D:\\");
            comboBox3.Items.Add("E:\\");


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

        private void button1_Click(object sender, EventArgs e)
        {
            string spath = comboBox1.Text + comboBox2.Text + "\\" + textBox1.Text;
            try
            {
                if (!File.Exists(spath))
                {
                    Directory.CreateDirectory(spath);
                    MessageBox.Show("Folder Has been Created");
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
            this.panel1.Show();
           
            

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
            Fililing fi  = new Fililing();
            fi.Show();
            this.panel1.Show();


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(comboBox3.Text);
            DirectoryInfo[] d = dir.GetDirectories();
            foreach (DirectoryInfo df in d)
            {
                comboBox4.Items.Add(df);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string spath = comboBox3.Text + comboBox4.Text + "\\" + textBox2.Text + ".txt";
            try
            {
                if (!File.Exists(spath))
                {

                    File.Create(spath);
                    MessageBox.Show("File Has Been Created");

                }
                else
                {

                    MessageBox.Show("File already Exists");


                }
            }
            catch (DuplicateNameException de)
            {
                MessageBox.Show(" plz write another name");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something was wrong");
            }

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

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
