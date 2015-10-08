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

namespace LordofFaillingsLPToolkit
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmGenerator : System.Windows.Forms.Form
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.txtPlaylist = new System.Windows.Forms.TextBox();
            this.lblEFolge = new System.Windows.Forms.Label();
            this.txtErsteFolge = new System.Windows.Forms.TextBox();
            this.txtMitspieler = new System.Windows.Forms.TextBox();
            this.chbMitspieler = new System.Windows.Forms.CheckBox();
            this.lblSpielname = new System.Windows.Forms.Label();
            this.txtSpielname = new System.Windows.Forms.TextBox();
            this.lblBeschreibung = new System.Windows.Forms.Label();
            this.txtBeschreibung = new System.Windows.Forms.TextBox();
            this.chbZusatz = new System.Windows.Forms.CheckBox();
            this.txtZusatz = new System.Windows.Forms.TextBox();
            this.lblBeschreibungZ = new System.Windows.Forms.Label();
            this.lblJahr = new System.Windows.Forms.Label();
            this.txtJahr = new System.Windows.Forms.TextBox();
            this.txtSpieleLink = new System.Windows.Forms.TextBox();
            this.lblSpielLink = new System.Windows.Forms.Label();
            this.btnErstellen = new System.Windows.Forms.Button();
            this.txtErgebnis = new System.Windows.Forms.TextBox();
            this.lbldes = new System.Windows.Forms.Label();
            this.txtBeschreibungZ = new System.Windows.Forms.TextBox();
            this.lbldes2 = new System.Windows.Forms.Label();
            this.lbletc = new System.Windows.Forms.Label();
            this.chbTogether = new System.Windows.Forms.CheckBox();
            this.txtMusik = new System.Windows.Forms.TextBox();
            this.chbMusik = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(639, 16);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Dieses Programm erleichtert dir eine Beschreibung für dein/e Youtube Video/s zu e" +
    "rstellen. ";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.Location = new System.Drawing.Point(12, 35);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(500, 16);
            this.lblInfo2.TabIndex = 1;
            this.lblInfo2.Text = "Fülle dazu einfach die Felder aus und drücke auf den \"Erstellen\" Button.";
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.Location = new System.Drawing.Point(12, 74);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(117, 16);
            this.lblPlaylist.TabIndex = 2;
            this.lblPlaylist.Text = "Playlistshortlink";
            // 
            // txtPlaylist
            // 
            this.txtPlaylist.Location = new System.Drawing.Point(135, 70);
            this.txtPlaylist.Name = "txtPlaylist";
            this.txtPlaylist.Size = new System.Drawing.Size(516, 20);
            this.txtPlaylist.TabIndex = 3;
            // 
            // lblEFolge
            // 
            this.lblEFolge.AutoSize = true;
            this.lblEFolge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEFolge.Location = new System.Drawing.Point(12, 97);
            this.lblEFolge.Name = "lblEFolge";
            this.lblEFolge.Size = new System.Drawing.Size(120, 16);
            this.lblEFolge.TabIndex = 4;
            this.lblEFolge.Text = "Erste Folge Link";
            // 
            // txtErsteFolge
            // 
            this.txtErsteFolge.Location = new System.Drawing.Point(135, 96);
            this.txtErsteFolge.Name = "txtErsteFolge";
            this.txtErsteFolge.Size = new System.Drawing.Size(516, 20);
            this.txtErsteFolge.TabIndex = 5;
            // 
            // txtMitspieler
            // 
            this.txtMitspieler.Location = new System.Drawing.Point(135, 122);
            this.txtMitspieler.Multiline = true;
            this.txtMitspieler.Name = "txtMitspieler";
            this.txtMitspieler.Size = new System.Drawing.Size(516, 20);
            this.txtMitspieler.TabIndex = 9;
            // 
            // chbMitspieler
            // 
            this.chbMitspieler.AutoSize = true;
            this.chbMitspieler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMitspieler.Location = new System.Drawing.Point(15, 122);
            this.chbMitspieler.Name = "chbMitspieler";
            this.chbMitspieler.Size = new System.Drawing.Size(95, 20);
            this.chbMitspieler.TabIndex = 10;
            this.chbMitspieler.Text = "Mitspieler";
            this.chbMitspieler.UseVisualStyleBackColor = true;
            this.chbMitspieler.CheckedChanged += new System.EventHandler(this.chbMitspieler_CheckedChanged);
            // 
            // lblSpielname
            // 
            this.lblSpielname.AutoSize = true;
            this.lblSpielname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpielname.Location = new System.Drawing.Point(12, 240);
            this.lblSpielname.Name = "lblSpielname";
            this.lblSpielname.Size = new System.Drawing.Size(82, 16);
            this.lblSpielname.TabIndex = 11;
            this.lblSpielname.Text = "Spielname";
            // 
            // txtSpielname
            // 
            this.txtSpielname.Location = new System.Drawing.Point(135, 239);
            this.txtSpielname.Name = "txtSpielname";
            this.txtSpielname.Size = new System.Drawing.Size(516, 20);
            this.txtSpielname.TabIndex = 12;
            // 
            // lblBeschreibung
            // 
            this.lblBeschreibung.AutoSize = true;
            this.lblBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschreibung.Location = new System.Drawing.Point(12, 265);
            this.lblBeschreibung.Name = "lblBeschreibung";
            this.lblBeschreibung.Size = new System.Drawing.Size(103, 16);
            this.lblBeschreibung.TabIndex = 13;
            this.lblBeschreibung.Text = "Beschreibung";
            // 
            // txtBeschreibung
            // 
            this.txtBeschreibung.Location = new System.Drawing.Point(135, 265);
            this.txtBeschreibung.Multiline = true;
            this.txtBeschreibung.Name = "txtBeschreibung";
            this.txtBeschreibung.Size = new System.Drawing.Size(516, 59);
            this.txtBeschreibung.TabIndex = 14;
            // 
            // chbZusatz
            // 
            this.chbZusatz.AutoSize = true;
            this.chbZusatz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbZusatz.Location = new System.Drawing.Point(15, 148);
            this.chbZusatz.Name = "chbZusatz";
            this.chbZusatz.Size = new System.Drawing.Size(120, 20);
            this.chbZusatz.TabIndex = 15;
            this.chbZusatz.Text = "Modpack etc.";
            this.chbZusatz.UseVisualStyleBackColor = true;
            this.chbZusatz.CheckedChanged += new System.EventHandler(this.chbZusatz_CheckedChanged);
            // 
            // txtZusatz
            // 
            this.txtZusatz.Location = new System.Drawing.Point(135, 148);
            this.txtZusatz.Name = "txtZusatz";
            this.txtZusatz.Size = new System.Drawing.Size(516, 20);
            this.txtZusatz.TabIndex = 16;
            // 
            // lblBeschreibungZ
            // 
            this.lblBeschreibungZ.AutoSize = true;
            this.lblBeschreibungZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschreibungZ.Location = new System.Drawing.Point(12, 175);
            this.lblBeschreibungZ.Name = "lblBeschreibungZ";
            this.lblBeschreibungZ.Size = new System.Drawing.Size(103, 16);
            this.lblBeschreibungZ.TabIndex = 17;
            this.lblBeschreibungZ.Text = "Beschreibung";
            // 
            // lblJahr
            // 
            this.lblJahr.AutoSize = true;
            this.lblJahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJahr.Location = new System.Drawing.Point(12, 331);
            this.lblJahr.Name = "lblJahr";
            this.lblJahr.Size = new System.Drawing.Size(38, 16);
            this.lblJahr.TabIndex = 19;
            this.lblJahr.Text = "Jahr";
            // 
            // txtJahr
            // 
            this.txtJahr.Location = new System.Drawing.Point(135, 330);
            this.txtJahr.Name = "txtJahr";
            this.txtJahr.Size = new System.Drawing.Size(516, 20);
            this.txtJahr.TabIndex = 20;
            // 
            // txtSpieleLink
            // 
            this.txtSpieleLink.Location = new System.Drawing.Point(135, 356);
            this.txtSpieleLink.Name = "txtSpieleLink";
            this.txtSpieleLink.Size = new System.Drawing.Size(516, 20);
            this.txtSpieleLink.TabIndex = 21;
            // 
            // lblSpielLink
            // 
            this.lblSpielLink.AutoSize = true;
            this.lblSpielLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpielLink.Location = new System.Drawing.Point(12, 356);
            this.lblSpielLink.Name = "lblSpielLink";
            this.lblSpielLink.Size = new System.Drawing.Size(77, 16);
            this.lblSpielLink.TabIndex = 22;
            this.lblSpielLink.Text = "Spielelink";
            // 
            // btnErstellen
            // 
            this.btnErstellen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErstellen.Location = new System.Drawing.Point(15, 453);
            this.btnErstellen.Name = "btnErstellen";
            this.btnErstellen.Size = new System.Drawing.Size(636, 49);
            this.btnErstellen.TabIndex = 23;
            this.btnErstellen.Text = "Beschreibung Erstellen";
            this.btnErstellen.UseVisualStyleBackColor = true;
            this.btnErstellen.Click += new System.EventHandler(this.btnErstellen_Click);
            // 
            // txtErgebnis
            // 
            this.txtErgebnis.Location = new System.Drawing.Point(15, 508);
            this.txtErgebnis.Multiline = true;
            this.txtErgebnis.Name = "txtErgebnis";
            this.txtErgebnis.ReadOnly = true;
            this.txtErgebnis.Size = new System.Drawing.Size(636, 118);
            this.txtErgebnis.TabIndex = 24;
            // 
            // lbldes
            // 
            this.lbldes.AutoSize = true;
            this.lbldes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldes.Location = new System.Drawing.Point(12, 284);
            this.lbldes.Name = "lbldes";
            this.lbldes.Size = new System.Drawing.Size(82, 16);
            this.lbldes.TabIndex = 25;
            this.lbldes.Text = "des Spiels";
            // 
            // txtBeschreibungZ
            // 
            this.txtBeschreibungZ.Location = new System.Drawing.Point(135, 174);
            this.txtBeschreibungZ.Multiline = true;
            this.txtBeschreibungZ.Name = "txtBeschreibungZ";
            this.txtBeschreibungZ.Size = new System.Drawing.Size(516, 59);
            this.txtBeschreibungZ.TabIndex = 27;
            // 
            // lbldes2
            // 
            this.lbldes2.AutoSize = true;
            this.lbldes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldes2.Location = new System.Drawing.Point(12, 195);
            this.lbldes2.Name = "lbldes2";
            this.lbldes2.Size = new System.Drawing.Size(110, 16);
            this.lbldes2.TabIndex = 28;
            this.lbldes2.Text = "des Modpacks";
            // 
            // lbletc
            // 
            this.lbletc.AutoSize = true;
            this.lbletc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbletc.Location = new System.Drawing.Point(12, 217);
            this.lbletc.Name = "lbletc";
            this.lbletc.Size = new System.Drawing.Size(33, 16);
            this.lbletc.TabIndex = 30;
            this.lbletc.Text = "etc.";
            // 
            // chbTogether
            // 
            this.chbTogether.AutoSize = true;
            this.chbTogether.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTogether.Location = new System.Drawing.Point(15, 308);
            this.chbTogether.Name = "chbTogether";
            this.chbTogether.Size = new System.Drawing.Size(98, 20);
            this.chbTogether.TabIndex = 31;
            this.chbTogether.Text = "Together?";
            this.chbTogether.UseVisualStyleBackColor = true;
            // 
            // txtMusik
            // 
            this.txtMusik.Location = new System.Drawing.Point(135, 382);
            this.txtMusik.Multiline = true;
            this.txtMusik.Name = "txtMusik";
            this.txtMusik.Size = new System.Drawing.Size(516, 59);
            this.txtMusik.TabIndex = 32;
            // 
            // chbMusik
            // 
            this.chbMusik.AutoSize = true;
            this.chbMusik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMusik.Location = new System.Drawing.Point(15, 382);
            this.chbMusik.Name = "chbMusik";
            this.chbMusik.Size = new System.Drawing.Size(67, 20);
            this.chbMusik.TabIndex = 33;
            this.chbMusik.Text = "Musik";
            this.chbMusik.UseVisualStyleBackColor = true;
            this.chbMusik.CheckedChanged += new System.EventHandler(this.chbMusik_CheckedChanged);
            // 
            // frmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 635);
            this.Controls.Add(this.chbMusik);
            this.Controls.Add(this.txtMusik);
            this.Controls.Add(this.chbTogether);
            this.Controls.Add(this.lbletc);
            this.Controls.Add(this.lbldes2);
            this.Controls.Add(this.txtBeschreibungZ);
            this.Controls.Add(this.lbldes);
            this.Controls.Add(this.txtErgebnis);
            this.Controls.Add(this.btnErstellen);
            this.Controls.Add(this.lblSpielLink);
            this.Controls.Add(this.txtSpieleLink);
            this.Controls.Add(this.txtJahr);
            this.Controls.Add(this.lblJahr);
            this.Controls.Add(this.lblBeschreibungZ);
            this.Controls.Add(this.txtZusatz);
            this.Controls.Add(this.chbZusatz);
            this.Controls.Add(this.txtBeschreibung);
            this.Controls.Add(this.lblBeschreibung);
            this.Controls.Add(this.txtSpielname);
            this.Controls.Add(this.lblSpielname);
            this.Controls.Add(this.chbMitspieler);
            this.Controls.Add(this.txtMitspieler);
            this.Controls.Add(this.txtErsteFolge);
            this.Controls.Add(this.lblEFolge);
            this.Controls.Add(this.txtPlaylist);
            this.Controls.Add(this.lblPlaylist);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo);
            this.MaximumSize = new System.Drawing.Size(683, 674);
            this.MinimumSize = new System.Drawing.Size(683, 674);
            this.Name = "frmGenerator";
            this.Text = "ShowCast\'s Beschreibungs Generator v1.1";
            this.Load += new System.EventHandler(this.frmGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.Label lblInfo;
        internal System.Windows.Forms.Label lblInfo2;
        internal System.Windows.Forms.Label lblPlaylist;
        internal System.Windows.Forms.TextBox txtPlaylist;
        internal System.Windows.Forms.Label lblEFolge;
        internal System.Windows.Forms.TextBox txtErsteFolge;
        internal System.Windows.Forms.TextBox txtMitspieler;
        internal System.Windows.Forms.CheckBox chbMitspieler;
        internal System.Windows.Forms.Label lblSpielname;
        internal System.Windows.Forms.TextBox txtSpielname;
        internal System.Windows.Forms.Label lblBeschreibung;
        internal System.Windows.Forms.TextBox txtBeschreibung;
        internal System.Windows.Forms.CheckBox chbZusatz;
        internal System.Windows.Forms.TextBox txtZusatz;
        internal System.Windows.Forms.Label lblBeschreibungZ;
        internal System.Windows.Forms.Label lblJahr;
        internal System.Windows.Forms.TextBox txtJahr;
        internal System.Windows.Forms.TextBox txtSpieleLink;
        internal System.Windows.Forms.Label lblSpielLink;
        internal System.Windows.Forms.Button btnErstellen;
        internal System.Windows.Forms.TextBox txtErgebnis;
        internal System.Windows.Forms.Label lbldes;
        internal System.Windows.Forms.TextBox txtBeschreibungZ;
        internal System.Windows.Forms.Label lbldes2;
        internal System.Windows.Forms.Label lbletc;
        internal System.Windows.Forms.CheckBox chbTogether;
        internal System.Windows.Forms.TextBox txtMusik;
        internal System.Windows.Forms.CheckBox chbMusik;

    }

}