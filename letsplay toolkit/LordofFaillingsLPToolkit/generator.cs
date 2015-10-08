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
	public partial class frmGenerator
	{

		internal frmGenerator()
		{
			InitializeComponent();
		}

		private void frmGenerator_Load(object sender, System.EventArgs e)
		{
			lblInfo.Text = "Dieses Programm erleichtert dir eine Beschreibung für dein/e Youtube Video/s zu erstellen";
			lblInfo2.Text = "Fülle dazu einfach die Felder aus und drücke auf den 'Erstellen' Button.";
			txtMitspieler.Enabled = false;
			txtZusatz.Enabled = false;
			txtBeschreibungZ.Enabled = false;
			txtMusik.Enabled = false;
		}

		private void btnErstellen_Click(object sender, System.EventArgs e)
		{
			txtErgebnis.Text = " ";
			if (chbMitspieler.Checked == false)
			{
				txtErgebnis.Text = "► Playlist: " + txtPlaylist.Text + Environment.NewLine + "► ERSTE FOLGE: " + txtErsteFolge.Text + Environment.NewLine + Environment.NewLine + "------------" + Environment.NewLine + "«" + txtSpielname.Text + "»" + Environment.NewLine + txtBeschreibung.Text + Environment.NewLine + Environment.NewLine + "«Let's Play " + txtSpielname.Text + "»" + Environment.NewLine + "Kommentiertes Gameplay von ShowCast (" + txtJahr.Text + ")." + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "WICHTIGER HINWEIS:" + Environment.NewLine + "Wenn Dir das Spiel gefällt, bitte unterstütze die Entwickler und kaufe Dir das Spiel im Original!" + Environment.NewLine + "Shortlink: " + txtSpieleLink.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Bekomm immer den aktuellsten Bullshit von mir auf deine Startseite«" + Environment.NewLine + "http://goo.gl/Y4RUJK" + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Facebook«" + Environment.NewLine + "Paul: https://www.facebook.com/ShowCastification" + Environment.NewLine + "Tim: https://www.facebook.com/LordOFFailling";
			}
			else
			{
				txtErgebnis.Text = "► Playlist: " + txtPlaylist.Text + Environment.NewLine + "► ERSTE FOLGE: " + txtErsteFolge.Text + Environment.NewLine + Environment.NewLine + "► Mitspieler:" + Environment.NewLine + txtMitspieler.Text + Environment.NewLine + Environment.NewLine + "------------" + Environment.NewLine + "«" + txtSpielname.Text + "»" + Environment.NewLine + txtBeschreibung.Text + Environment.NewLine + Environment.NewLine + "«Let's Play Together " + txtSpielname.Text + "»" + Environment.NewLine + "Kommentiertes Gameplay von ShowCast (" + txtJahr.Text + ")." + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "WICHTIGER HINWEIS:" + Environment.NewLine + "Wenn Dir das Spiel gefällt, bitte unterstütze die Entwickler und kaufe Dir das Spiel im Original!" + Environment.NewLine + "Shortlink: " + txtSpieleLink.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Bekomm immer den aktuellsten Bullshit von mir auf deine Startseite«" + Environment.NewLine + "http://goo.gl/Y4RUJK" + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Facebook«" + Environment.NewLine + "Paul: https://www.facebook.com/ShowCastification" + Environment.NewLine + "Tim: https://www.facebook.com/LordOFFailling";
			}
			if (chbZusatz.Checked == true)
			{
				txtErgebnis.Text = "► Playlist: " + txtPlaylist.Text + Environment.NewLine + "► ERSTE FOLGE: " + txtErsteFolge.Text + Environment.NewLine + Environment.NewLine + "------------" + Environment.NewLine + "«" + txtZusatz.Text + "»" + Environment.NewLine + txtBeschreibungZ.Text + Environment.NewLine + Environment.NewLine + "«" + txtSpielname.Text + "»" + Environment.NewLine + txtBeschreibung.Text + Environment.NewLine + Environment.NewLine + "«Let's Play " + txtZusatz.Text + "»" + Environment.NewLine + "Kommentiertes Gameplay von ShowCast (" + txtJahr.Text + ")." + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "WICHTIGER HINWEIS:" + Environment.NewLine + "Wenn Dir das Spiel gefällt, bitte unterstütze die Entwickler und kaufe Dir das Spiel im Original!" + Environment.NewLine + "Shortlink: " + txtSpieleLink.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Bekomm immer den aktuellsten Bullshit von mir auf deine Startseite«" + Environment.NewLine + "http://goo.gl/Y4RUJK" + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Facebook«" + Environment.NewLine + "Paul: https://www.facebook.com/ShowCastification" + Environment.NewLine + "Tim: https://www.facebook.com/LordOFFailling";
			}
			if (chbMitspieler.Checked == true && chbZusatz.Checked == true)
			{
				txtErgebnis.Text = "► Playlist: " + txtPlaylist.Text + Environment.NewLine + "► ERSTE FOLGE: " + txtErsteFolge.Text + Environment.NewLine + Environment.NewLine + "► Mitspieler:" + Environment.NewLine + txtMitspieler.Text + Environment.NewLine + Environment.NewLine + "------------" + Environment.NewLine + "«" + txtZusatz.Text + "»" + Environment.NewLine + txtBeschreibungZ.Text + Environment.NewLine + Environment.NewLine + "«" + txtSpielname.Text + "»" + Environment.NewLine + txtBeschreibung.Text + Environment.NewLine + Environment.NewLine + "«Let's Play Together " + txtZusatz.Text + "»" + Environment.NewLine + "Kommentiertes Gameplay von ShowCast (" + txtJahr.Text + ")." + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "WICHTIGER HINWEIS:" + Environment.NewLine + "Wenn Dir das Spiel gefällt, bitte unterstütze die Entwickler und kaufe Dir das Spiel im Original!" + Environment.NewLine + "Shortlink: " + txtSpieleLink.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Bekomm immer den aktuellsten Bullshit von mir auf deine Startseite«" + Environment.NewLine + "http://goo.gl/Y4RUJK" + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Facebook«" + Environment.NewLine + "Paul: https://www.facebook.com/ShowCastification" + Environment.NewLine + "Tim: https://www.facebook.com/LordOFFailling";
			}
			if (chbTogether.Checked == true)
			{
				txtErgebnis.Text = "► Playlist: " + txtPlaylist.Text + Environment.NewLine + "► ERSTE FOLGE: " + txtErsteFolge.Text + Environment.NewLine + Environment.NewLine + "------------" + Environment.NewLine + "«" + txtSpielname.Text + "»" + Environment.NewLine + txtBeschreibung.Text + Environment.NewLine + Environment.NewLine + "«Let's Play Together " + txtSpielname.Text + "»" + Environment.NewLine + "Kommentiertes Gameplay von ShowCast (" + txtJahr.Text + ")." + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "WICHTIGER HINWEIS:" + Environment.NewLine + "Wenn Dir das Spiel gefällt, bitte unterstütze die Entwickler und kaufe Dir das Spiel im Original!" + Environment.NewLine + "Shortlink: " + txtSpieleLink.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Bekomm immer den aktuellsten Bullshit von mir auf deine Startseite«" + Environment.NewLine + "http://goo.gl/Y4RUJK" + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Facebook«" + Environment.NewLine + "Paul: https://www.facebook.com/ShowCastification" + Environment.NewLine + "Tim: https://www.facebook.com/LordOFFailling";
			}
			if (chbMitspieler.Checked == true && chbTogether.Checked == true && chbZusatz.Checked == true)
			{
				txtErgebnis.Text = "► Playlist: " + txtPlaylist.Text + Environment.NewLine + "► ERSTE FOLGE: " + txtErsteFolge.Text + Environment.NewLine + Environment.NewLine + "► Mitspieler:" + Environment.NewLine + txtMitspieler.Text + Environment.NewLine + Environment.NewLine + "------------" + Environment.NewLine + "«" + txtZusatz.Text + "»" + Environment.NewLine + txtBeschreibungZ.Text + Environment.NewLine + Environment.NewLine + "«" + txtSpielname.Text + "»" + Environment.NewLine + txtBeschreibung.Text + Environment.NewLine + Environment.NewLine + "«Let's Play Together " + txtSpielname.Text + "»" + Environment.NewLine + "Kommentiertes Gameplay von ShowCast (" + txtJahr.Text + ")." + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "WICHTIGER HINWEIS:" + Environment.NewLine + "Wenn Dir das Spiel gefällt, bitte unterstütze die Entwickler und kaufe Dir das Spiel im Original!" + Environment.NewLine + "Shortlink: " + txtSpieleLink.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Bekomm immer den aktuellsten Bullshit von mir auf deine Startseite«" + Environment.NewLine + "http://goo.gl/Y4RUJK" + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Facebook«" + Environment.NewLine + "Paul: https://www.facebook.com/ShowCastification" + Environment.NewLine + "Tim: https://www.facebook.com/LordOFFailling";
			}
			if (chbMusik.Checked)
			{
				txtErgebnis.Text = "► Playlist: " + txtPlaylist.Text + Environment.NewLine + "► ERSTE FOLGE: " + txtErsteFolge.Text + Environment.NewLine + Environment.NewLine + "------------" + Environment.NewLine + "«" + txtSpielname.Text + "»" + Environment.NewLine + txtBeschreibung.Text + Environment.NewLine + Environment.NewLine + "«Let's Play " + txtSpielname.Text + "»" + Environment.NewLine + "Kommentiertes Gameplay von ShowCast (" + txtJahr.Text + ")." + Environment.NewLine + Environment.NewLine + "Musik:" + Environment.NewLine + txtMusik.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "WICHTIGER HINWEIS:" + Environment.NewLine + "Wenn Dir das Spiel gefällt, bitte unterstütze die Entwickler und kaufe Dir das Spiel im Original!" + Environment.NewLine + "Shortlink: " + txtSpieleLink.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Bekomm immer den aktuellsten Bullshit von mir auf deine Startseite«" + Environment.NewLine + "http://goo.gl/Y4RUJK" + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Facebook«" + Environment.NewLine + "Paul: https://www.facebook.com/ShowCastification" + Environment.NewLine + "Tim: https://www.facebook.com/LordOFFailling";
			}
			if (chbMitspieler.Checked == true && chbZusatz.Checked == true && chbMusik.Checked == true)
			{
				txtErgebnis.Text = "► Playlist: " + txtPlaylist.Text + Environment.NewLine + "► ERSTE FOLGE: " + txtErsteFolge.Text + Environment.NewLine + Environment.NewLine + "► Mitspieler:" + Environment.NewLine + txtMitspieler.Text + Environment.NewLine + Environment.NewLine + "------------" + Environment.NewLine + "«" + txtZusatz.Text + "»" + Environment.NewLine + txtBeschreibungZ.Text + Environment.NewLine + Environment.NewLine + "«" + txtSpielname.Text + "»" + Environment.NewLine + txtBeschreibung.Text + Environment.NewLine + Environment.NewLine + "«Let's Play Together " + txtZusatz.Text + "»" + Environment.NewLine + "Kommentiertes Gameplay von ShowCast (" + txtJahr.Text + ")." + Environment.NewLine + Environment.NewLine + "Musik:" + Environment.NewLine + txtMusik.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "WICHTIGER HINWEIS:" + Environment.NewLine + "Wenn Dir das Spiel gefällt, bitte unterstütze die Entwickler und kaufe Dir das Spiel im Original!" + Environment.NewLine + "Shortlink: " + txtSpieleLink.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Bekomm immer den aktuellsten Bullshit von mir auf deine Startseite«" + Environment.NewLine + "http://goo.gl/Y4RUJK" + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Facebook«" + Environment.NewLine + "Paul: https://www.facebook.com/ShowCastification" + Environment.NewLine + "Tim: https://www.facebook.com/LordOFFailling";
			}
			if (chbZusatz.Checked == true && chbMusik.Checked == true)
			{
				txtErgebnis.Text = "► Playlist: " + txtPlaylist.Text + Environment.NewLine + "► ERSTE FOLGE: " + txtErsteFolge.Text + Environment.NewLine + Environment.NewLine + "------------" + Environment.NewLine + "«" + txtZusatz.Text + "»" + Environment.NewLine + txtBeschreibungZ.Text + Environment.NewLine + Environment.NewLine + "«" + txtSpielname.Text + "»" + Environment.NewLine + txtBeschreibung.Text + Environment.NewLine + Environment.NewLine + "«Let's Play " + txtZusatz.Text + "»" + Environment.NewLine + "Kommentiertes Gameplay von ShowCast (" + txtJahr.Text + ")." + Environment.NewLine + Environment.NewLine + "Musik:" + Environment.NewLine + txtMusik.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "WICHTIGER HINWEIS:" + Environment.NewLine + "Wenn Dir das Spiel gefällt, bitte unterstütze die Entwickler und kaufe Dir das Spiel im Original!" + Environment.NewLine + "Shortlink: " + txtSpieleLink.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Bekomm immer den aktuellsten Bullshit von mir auf deine Startseite«" + Environment.NewLine + "http://goo.gl/Y4RUJK" + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Facebook«" + Environment.NewLine + "Paul: https://www.facebook.com/ShowCastification" + Environment.NewLine + "Tim: https://www.facebook.com/LordOFFailling";
			}
			if (chbMitspieler.Checked == true && chbTogether.Checked == true && chbZusatz.Checked && chbMusik.Checked == true)
			{
				txtErgebnis.Text = "► Playlist: " + txtPlaylist.Text + Environment.NewLine + "► ERSTE FOLGE: " + txtErsteFolge.Text + Environment.NewLine + Environment.NewLine + "► Mitspieler:" + Environment.NewLine + txtMitspieler.Text + Environment.NewLine + Environment.NewLine + "------------" + Environment.NewLine + "«" + txtZusatz.Text + "»" + Environment.NewLine + txtBeschreibungZ.Text + Environment.NewLine + Environment.NewLine + "«" + txtSpielname.Text + "»" + Environment.NewLine + txtBeschreibung.Text + Environment.NewLine + Environment.NewLine + "«Let's Play Together " + txtSpielname.Text + "»" + Environment.NewLine + "Kommentiertes Gameplay von ShowCast (" + txtJahr.Text + ")." + Environment.NewLine + Environment.NewLine + "Musik:" + Environment.NewLine + txtMusik.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "WICHTIGER HINWEIS:" + Environment.NewLine + "Wenn Dir das Spiel gefällt, bitte unterstütze die Entwickler und kaufe Dir das Spiel im Original!" + Environment.NewLine + "Shortlink: " + txtSpieleLink.Text + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Bekomm immer den aktuellsten Bullshit von mir auf deine Startseite«" + Environment.NewLine + "http://goo.gl/Y4RUJK" + Environment.NewLine + Environment.NewLine + "-----------" + Environment.NewLine + "»Facebook«" + Environment.NewLine + "Paul: https://www.facebook.com/ShowCastification" + Environment.NewLine + "Tim: https://www.facebook.com/LordOFFailling";
			}

			//If txtPlaylist.Text = " " Or txtErsteFolge.Text = " " Or txtSpielname.Text = " " Or txtBeschreibung.Text = " " Or txtJahr.Text = " " Or txtSpieleLink.Text = " " Then
			//MsgBox("Du hast ein Feld oder mehrere nicht Ausgefüllt")
			//End If

		}

		private void chbMitspieler_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbMitspieler.Checked == true)
			{
				txtMitspieler.Enabled = true;
			}
			if (chbMitspieler.Checked == false)
			{
				txtMitspieler.Enabled = false;
			}
		}

		private void chbZusatz_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbZusatz.Checked == true)
			{
				txtZusatz.Enabled = true;
				txtBeschreibungZ.Enabled = true;
			}
			if (chbZusatz.Checked == false)
			{
				txtZusatz.Enabled = false;
				txtBeschreibungZ.Enabled = false;
			}

		}

		private void chbMusik_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chbMusik.Checked == false)
			{
				txtMusik.Enabled = false;
			}
			if (chbMusik.Checked == true)
			{
				txtMusik.Enabled = true;
			}
		}

		private static frmGenerator _DefaultInstance;
		public static frmGenerator DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null)
					_DefaultInstance = new frmGenerator();

				return _DefaultInstance;
			}
		}

    }

}