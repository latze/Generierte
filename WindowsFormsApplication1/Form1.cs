using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = Path.Combine(Application.StartupPath, "Bilder");
            gebdatum.Format = DateTimePickerFormat.Custom;
            gebdatum.CustomFormat = "dd.MM.yyyy";
            openFileDialog1.InitialDirectory = path;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bezeichnung_TextChanged(object sender, EventArgs e)
        {

        }

        static string RemoveDiacritics(string text) //Sonderzeichen entfernen (by Michael S. Kaplan)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        private void button1_Click(object sender, EventArgs e) //Erzeugen
        {
            string bild;
            string vor;
            string vor1;
            string nach;
            string kunst;
            string date;
            string date1;
            string bezkunst;
            int lange;


            vor = RemoveDiacritics(vorname.Text);
            nach = RemoveDiacritics(nachname.Text);
            kunst = RemoveDiacritics(kunstlername.Text);
            date = gebdatum.Text;
            date1 = date.Replace(".", "");

            if (string.IsNullOrEmpty(vor))
                MessageBox.Show("Bitte trage einen Vornamen ein");
            else if (string.IsNullOrEmpty(nach))
                MessageBox.Show("Bitte trage einen Nachnamen ein");
            else
            {
                lange = vorname.TextLength - 2;
                vor1 = vor.Remove(2, lange);


                bild = nach + vor1 + date1 + ".png";
                bezkunst = kunst + date1 + ".png";

                if (string.IsNullOrEmpty(kunst))
                    bezeichnung.Text = bild;
                else
                    bezeichnung.Text = bezkunst;
            }
            button2.Enabled = true;           
        }

        private void b_bild_Click(object sender, EventArgs e) //Bild laden
        {
            string image;

            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "png Files | *.png";
            openFileDialog1.Title = "Bild auswählen";
            image = openFileDialog1.FileName;
            
            try {pictureBox1.Image = Image.FromFile(image); }
            catch (Exception)
            {
                MessageBox.Show("Bitte wähle ein Bild aus.");
            }

        }

        private void button2_Click(object sender, EventArgs e) //Bild speichern
        {
            string image;
            string bez;

            bez = bezeichnung.Text;
            image = pictureBox1.ImageLocation;
            
            saveFileDialog1.Title = "Bild auswählen";
            saveFileDialog1.FileName = bez;
            if (pictureBox1.Image != null)
                {
                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);


                        pictureBox1.Image.Save(saveFileDialog1.FileName);
                    }
                 }
            else
                MessageBox.Show("Bitte wähle ein Bild über den Button Bild laden");
        }

        private void button3_Click(object sender, EventArgs e) //Beenden
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e) //Verlinkung FM Zocker
        {
            System.Diagnostics.Process.Start("http://www.fm-zocker.de");
        }
    }
}
