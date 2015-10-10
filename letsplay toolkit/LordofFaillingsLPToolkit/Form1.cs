//INSTANT C# NOTE: Formerly VB project-level imports:
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
using System.Threading;
using System.IO;
using System.Reflection;

namespace LordofFaillingsLPToolkit
{
    public partial class startseite
    {
        internal startseite()
        {
            InitializeComponent();
        }

        private void startseite_Load(object sender, EventArgs e)
        {
            EinstellungenToolStripMenuItem.Enabled = false;
        }

        private void SchließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void EinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon", "Not available");
            //einstellung.DefaultInstance.Show();

        }

        private void beschr_button_Click(object sender, EventArgs e)
        {
            frmGenerator gnr = new frmGenerator();
            gnr.Show();
        }

        private void lpt_button_Click(object sender, EventArgs e)
        {
            letsplaytimer lpt = new letsplaytimer();
            lpt.Show();
        }

        private static startseite _DefaultInstance;
        public static startseite DefaultInstance
        {
            get
            {
                if (_DefaultInstance == null)
                    _DefaultInstance = new startseite();

                return _DefaultInstance;
            }
        }

        private void copyrightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © by ShowCast \nCopyright © by LordOfFailling \n", "Copyrights");
        }
    }
}