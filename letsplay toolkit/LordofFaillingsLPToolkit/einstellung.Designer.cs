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
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class einstellung : System.Windows.Forms.Form
	{
		//Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Wird vom Windows Form-Designer benötigt.
		private System.ComponentModel.IContainer components;

		//Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
		//Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
		//Das Bearbeiten mit dem Code-Editor ist nicht möglich.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(einstellung));
            this.TabControlEinstellung = new System.Windows.Forms.TabControl();
            this.TabPageYoutube = new System.Windows.Forms.TabPage();
            this.TabPageEinstellungen = new System.Windows.Forms.TabPage();
            this.TabControlEinstellung.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlEinstellung
            // 
            this.TabControlEinstellung.Controls.Add(this.TabPageYoutube);
            this.TabControlEinstellung.Controls.Add(this.TabPageEinstellungen);
            this.TabControlEinstellung.Location = new System.Drawing.Point(12, 12);
            this.TabControlEinstellung.Name = "TabControlEinstellung";
            this.TabControlEinstellung.SelectedIndex = 0;
            this.TabControlEinstellung.Size = new System.Drawing.Size(604, 215);
            this.TabControlEinstellung.TabIndex = 0;
            // 
            // TabPageYoutube
            // 
            this.TabPageYoutube.Location = new System.Drawing.Point(4, 22);
            this.TabPageYoutube.Name = "TabPageYoutube";
            this.TabPageYoutube.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageYoutube.Size = new System.Drawing.Size(596, 189);
            this.TabPageYoutube.TabIndex = 0;
            this.TabPageYoutube.Text = "Youtube";
            this.TabPageYoutube.UseVisualStyleBackColor = true;
            // 
            // TabPageEinstellungen
            // 
            this.TabPageEinstellungen.Location = new System.Drawing.Point(4, 22);
            this.TabPageEinstellungen.Name = "TabPageEinstellungen";
            this.TabPageEinstellungen.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageEinstellungen.Size = new System.Drawing.Size(596, 189);
            this.TabPageEinstellungen.TabIndex = 1;
            this.TabPageEinstellungen.Text = "Einstellungen";
            this.TabPageEinstellungen.UseVisualStyleBackColor = true;
            // 
            // einstellung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 239);
            this.Controls.Add(this.TabControlEinstellung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "einstellung";
            this.Text = "einstellung";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.einstellung_Closing);
            this.Load += new System.EventHandler(this.einstellung_Load);
            this.TabControlEinstellung.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		internal TabControl TabControlEinstellung;
		internal TabPage TabPageYoutube;
		internal TabPage TabPageEinstellungen;

		private static einstellung _DefaultInstance;

        public static einstellung DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null)
					_DefaultInstance = new einstellung();

				return _DefaultInstance;
			}
		}
	}

}