using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LordofFaillingsLPToolkit
{
    public partial class letsplaytimer : Form
    {
        public letsplaytimer()
        {
            InitializeComponent();
        }

    private void letsplaytimer_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(sektext.Text) > 60)
            {
                sektext.Text = "59";
            }
            if(true == true)
            {

            }
                stdtext.Enabled = false;
                mintext.Enabled = false;
                sektext.Enabled = false;
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            stdtext.Enabled = true;
            mintext.Enabled = true;
            sektext.Enabled = true;
        }
    }
}
