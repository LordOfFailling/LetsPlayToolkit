using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.IO;

namespace LordofFaillingsLPToolkit
{
	public partial class einstellung
	{
		internal einstellung()
		{
			InitializeComponent();
		}

		private void einstellung_Load(object sender, EventArgs e)
		{

		}
		private void einstellung_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			startseite.DefaultInstance.Show();
		}

        private void TabPageYoutube_Click(object sender, EventArgs e)
        {

        }

        private void jsonbutton_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "client_secret.json (.json)|*.json|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            var jsonname = openFileDialog1.FileName;
                            dpfad.Text = jsonname;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
    }