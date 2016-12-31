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

        public static void loadWASP(string file)
        {
            string fileWASP = file;
            if(file == "null")
            {
                MessageBox.Show("No file loaded.", "WASP");
            }
            else
            {
                MessageBox.Show("File Loaded: " + fileWASP, "WASP");
            }
        }
    }
}
