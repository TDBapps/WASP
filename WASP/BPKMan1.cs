using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WASP
{
    public partial class BPKMan1 : Form
    {
        public BPKMan1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (Directory.Exists(textBox1.Text))
                {
                    string output = textBox1.Text.Substring(textBox1.Text.Length - 1, 1);
                    if (output != @"\")
                    {
                        File.Create(textBox1.Text + @"\" + textBox2.Text + ".bpk").Dispose();
                        MessageBox.Show("File Created!", "WASP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        File.Create(textBox1.Text + textBox2.Text + ".bpk").Dispose();
                        MessageBox.Show("File Created!", "WASP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Error: Directory does not exist!", "WASP", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
