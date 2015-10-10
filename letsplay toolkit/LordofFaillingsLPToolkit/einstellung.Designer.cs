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
            this.label1 = new System.Windows.Forms.Label();
            this.dpfad = new System.Windows.Forms.TextBox();
            this.jsonbutton = new System.Windows.Forms.Button();
            this.TabPageEinstellungen = new System.Windows.Forms.TabPage();
            this.TabControlEinstellung.SuspendLayout();
            this.TabPageYoutube.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlEinstellung
            // 
            this.TabControlEinstellung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlEinstellung.Controls.Add(this.TabPageYoutube);
            this.TabControlEinstellung.Controls.Add(this.TabPageEinstellungen);
            this.TabControlEinstellung.Location = new System.Drawing.Point(12, 12);
            this.TabControlEinstellung.Name = "TabControlEinstellung";
            this.TabControlEinstellung.SelectedIndex = 0;
            this.TabControlEinstellung.Size = new System.Drawing.Size(447, 309);
            this.TabControlEinstellung.TabIndex = 0;
            // 
            // TabPageYoutube
            // 
            this.TabPageYoutube.Controls.Add(this.label1);
            this.TabPageYoutube.Controls.Add(this.dpfad);
            this.TabPageYoutube.Controls.Add(this.jsonbutton);
            this.TabPageYoutube.Location = new System.Drawing.Point(4, 22);
            this.TabPageYoutube.Name = "TabPageYoutube";
            this.TabPageYoutube.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageYoutube.Size = new System.Drawing.Size(439, 283);
            this.TabPageYoutube.TabIndex = 0;
            this.TabPageYoutube.Text = "Youtube";
            this.TabPageYoutube.UseVisualStyleBackColor = true;
            this.TabPageYoutube.Click += new System.EventHandler(this.TabPageYoutube_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Importiere deine .Json datei";
            // 
            // dpfad
            // 
            this.dpfad.Location = new System.Drawing.Point(113, 33);
            this.dpfad.Name = "dpfad";
            this.dpfad.Size = new System.Drawing.Size(188, 20);
            this.dpfad.TabIndex = 1;
            // 
            // jsonbutton
            // 
            this.jsonbutton.Location = new System.Drawing.Point(6, 33);
            this.jsonbutton.Name = "jsonbutton";
            this.jsonbutton.Size = new System.Drawing.Size(101, 20);
            this.jsonbutton.TabIndex = 0;
            this.jsonbutton.Text = "Durchsuchen";
            this.jsonbutton.UseVisualStyleBackColor = true;
            this.jsonbutton.Click += new System.EventHandler(this.jsonbutton_Click);
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
            this.ClientSize = new System.Drawing.Size(471, 333);
            this.Controls.Add(this.TabControlEinstellung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(487, 372);
            this.MinimumSize = new System.Drawing.Size(487, 372);
            this.Name = "einstellung";
            this.Text = "Einstellungen";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.einstellung_Closing);
            this.Load += new System.EventHandler(this.einstellung_Load);
            this.TabControlEinstellung.ResumeLayout(false);
            this.TabPageYoutube.ResumeLayout(false);
            this.TabPageYoutube.PerformLayout();
            this.ResumeLayout(false);

		}

		internal TabControl TabControlEinstellung;
		internal TabPage TabPageYoutube;
		internal TabPage TabPageEinstellungen;

		private static einstellung _DefaultInstance;
        private Button jsonbutton;
        private TextBox dpfad;
        private Label label1;

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