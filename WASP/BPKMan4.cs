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
    public partial class BPKMan4 : Form
    {
        public BPKMan4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = textBox1.Text.Substring(textBox1.Text.Length - 1, 1);
            if (output != @"\")
            {
                if (File.Exists(textBox1.Text + ".bpk"))
                {
                    string localPath = (textBox1.Text + ".bpk");
                    Global.bpk = Path.GetFileName(localPath);
                    Global.bpath = Path.GetFullPath(localPath);
                    WASP1.loadWASP(Global.bpk);
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error: Directory or file does not exist!", "WASP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Directory is invalid!", "WASP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.bpk = "null";
            Global.bpath = "null";
            MessageBox.Show("File unloaded.", "WASP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void BPKMan4_Load(object sender, EventArgs e)
        {
            if (Global.bpk != "null")
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else
            {
                textBox1.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }
    }
}
