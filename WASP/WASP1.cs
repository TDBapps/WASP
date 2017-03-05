using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WASP
{
    public partial class WASP1 : Form
    {
        public WASP1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        public static string loadWASP(string file)
        {
            string fileWASP = file;
            if(file == "null")
            {
                MessageBox.Show("No file loaded.", "WASP");
                return fileWASP;
            }
            else
            {
                MessageBox.Show("File Loaded: " + fileWASP, "WASP");
                return "null";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Global.bpk != "null")
            {
                MessageBox.Show("File Loaded: " + Global.bpk, "WASP");
            }
            else
            {
                MessageBox.Show("No file loaded.", "WASP");
            }
        }

        private void WASP1_Load(object sender, EventArgs e)
        {
            if(Global.bpk != "null")
            {
                this.Text = ("WASP: " + Global.bpk);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BPKMan().Show();
            this.Close();
        }
    }
}
