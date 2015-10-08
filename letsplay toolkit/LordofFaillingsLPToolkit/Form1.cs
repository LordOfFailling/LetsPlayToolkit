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

		}

		private void SchließenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Environment.Exit(1);
		}

		private void EinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			einstellung.DefaultInstance.Show();

		}

		private void beschr_button_Click(object sender, EventArgs e)
		{
            frmGenerator.DefaultInstance.Show();
        }

		private void lpt_button_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Comming Soon");
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
	}

}