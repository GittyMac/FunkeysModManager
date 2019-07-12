using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunkeyModManagers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles(".");

            foreach(string file in files)
            {
                listBox1.Items.Add(file);
                listBox1.Items.Remove(".\\FunkeyModManagers.exe");
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString() + " is now the active mod!");
            System.IO.File.Copy(listBox1.SelectedItem.ToString(), "../Main.swf", true);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}
