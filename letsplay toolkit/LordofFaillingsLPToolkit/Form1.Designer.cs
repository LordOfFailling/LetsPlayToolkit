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
	public partial class startseite : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startseite));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SchließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EinstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.beschr_button = new System.Windows.Forms.Button();
            this.lpt_button = new System.Windows.Forms.Button();
            this.ytlogin = new System.Windows.Forms.Button();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            resources.ApplyResources(this.MenuStrip1, "MenuStrip1");
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgrammToolStripMenuItem,
            this.OptionenToolStripMenuItem});
            this.MenuStrip1.Name = "MenuStrip1";
            // 
            // ProgrammToolStripMenuItem
            // 
            this.ProgrammToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SchließenToolStripMenuItem});
            this.ProgrammToolStripMenuItem.Name = "ProgrammToolStripMenuItem";
            resources.ApplyResources(this.ProgrammToolStripMenuItem, "ProgrammToolStripMenuItem");
            // 
            // SchließenToolStripMenuItem
            // 
            this.SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem";
            resources.ApplyResources(this.SchließenToolStripMenuItem, "SchließenToolStripMenuItem");
            this.SchließenToolStripMenuItem.Click += new System.EventHandler(this.SchließenToolStripMenuItem_Click);
            // 
            // OptionenToolStripMenuItem
            // 
            this.OptionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EinstellungenToolStripMenuItem});
            this.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem";
            resources.ApplyResources(this.OptionenToolStripMenuItem, "OptionenToolStripMenuItem");
            // 
            // EinstellungenToolStripMenuItem
            // 
            this.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem";
            resources.ApplyResources(this.EinstellungenToolStripMenuItem, "EinstellungenToolStripMenuItem");
            this.EinstellungenToolStripMenuItem.Click += new System.EventHandler(this.EinstellungenToolStripMenuItem_Click);
            // 
            // Panel1
            // 
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // beschr_button
            // 
            resources.ApplyResources(this.beschr_button, "beschr_button");
            this.beschr_button.Name = "beschr_button";
            this.beschr_button.UseVisualStyleBackColor = true;
            this.beschr_button.Click += new System.EventHandler(this.beschr_button_Click);
            // 
            // lpt_button
            // 
            resources.ApplyResources(this.lpt_button, "lpt_button");
            this.lpt_button.Name = "lpt_button";
            this.lpt_button.UseVisualStyleBackColor = true;
            this.lpt_button.Click += new System.EventHandler(this.lpt_button_Click);
            // 
            // ytlogin
            // 
            resources.ApplyResources(this.ytlogin, "ytlogin");
            this.ytlogin.Name = "ytlogin";
            this.ytlogin.UseVisualStyleBackColor = true;
            this.ytlogin.Click += new System.EventHandler(this.ytlogin_Click);
            // 
            // startseite
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ytlogin);
            this.Controls.Add(this.lpt_button);
            this.Controls.Add(this.beschr_button);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "startseite";
            this.Load += new System.EventHandler(this.startseite_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		internal MenuStrip MenuStrip1;
		internal ToolStripMenuItem ProgrammToolStripMenuItem;
		internal ToolStripMenuItem SchließenToolStripMenuItem;
		internal ToolStripMenuItem OptionenToolStripMenuItem;
		internal ToolStripMenuItem EinstellungenToolStripMenuItem;
		internal Panel Panel1;
		internal Button beschr_button;
		internal Button lpt_button;
        private Button ytlogin;
    }

}