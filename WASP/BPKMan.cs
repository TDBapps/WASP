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
    public partial class BPKMan : Form
    {
        public BPKMan()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new WASP1().Show();
            this.Close();
        }

        private void BPKMan_Load(object sender, EventArgs e)
        {
            if (Global.bpk == "null")
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button7.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BPKMan1().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new BPKMan4().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Global.bpk == "null")
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button7.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button7.Enabled = true;
            }
        }
    }
}
