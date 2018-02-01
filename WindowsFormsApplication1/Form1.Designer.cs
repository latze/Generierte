namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vorname = new System.Windows.Forms.TextBox();
            this.l_vorname = new System.Windows.Forms.Label();
            this.l_nachname = new System.Windows.Forms.Label();
            this.nachname = new System.Windows.Forms.TextBox();
            this.l_kunstlername = new System.Windows.Forms.Label();
            this.kunstlername = new System.Windows.Forms.TextBox();
            this.gebdatum = new System.Windows.Forms.DateTimePicker();
            this.l_gebdatum = new System.Windows.Forms.Label();
            this.l_header = new System.Windows.Forms.Label();
            this.bezeichnung = new System.Windows.Forms.TextBox();
            this.l_bezeichnung = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_bild = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // vorname
            // 
            this.vorname.Location = new System.Drawing.Point(15, 44);
            this.vorname.Name = "vorname";
            this.vorname.Size = new System.Drawing.Size(144, 20);
            this.vorname.TabIndex = 0;
            // 
            // l_vorname
            // 
            this.l_vorname.AutoSize = true;
            this.l_vorname.Location = new System.Drawing.Point(12, 28);
            this.l_vorname.Name = "l_vorname";
            this.l_vorname.Size = new System.Drawing.Size(49, 13);
            this.l_vorname.TabIndex = 1;
            this.l_vorname.Text = "Vorname";
            // 
            // l_nachname
            // 
            this.l_nachname.AutoSize = true;
            this.l_nachname.Location = new System.Drawing.Point(12, 78);
            this.l_nachname.Name = "l_nachname";
            this.l_nachname.Size = new System.Drawing.Size(59, 13);
            this.l_nachname.TabIndex = 3;
            this.l_nachname.Text = "Nachname";
            // 
            // nachname
            // 
            this.nachname.Location = new System.Drawing.Point(15, 94);
            this.nachname.Name = "nachname";
            this.nachname.Size = new System.Drawing.Size(144, 20);
            this.nachname.TabIndex = 2;
            // 
            // l_kunstlername
            // 
            this.l_kunstlername.AutoSize = true;
            this.l_kunstlername.Location = new System.Drawing.Point(12, 129);
            this.l_kunstlername.Name = "l_kunstlername";
            this.l_kunstlername.Size = new System.Drawing.Size(71, 13);
            this.l_kunstlername.TabIndex = 5;
            this.l_kunstlername.Text = "Künstlername";
            // 
            // kunstlername
            // 
            this.kunstlername.Location = new System.Drawing.Point(15, 145);
            this.kunstlername.Name = "kunstlername";
            this.kunstlername.Size = new System.Drawing.Size(144, 20);
            this.kunstlername.TabIndex = 4;
            // 
            // gebdatum
            // 
            this.gebdatum.Location = new System.Drawing.Point(15, 196);
            this.gebdatum.Name = "gebdatum";
            this.gebdatum.Size = new System.Drawing.Size(200, 20);
            this.gebdatum.TabIndex = 6;
            // 
            // l_gebdatum
            // 
            this.l_gebdatum.AutoSize = true;
            this.l_gebdatum.Location = new System.Drawing.Point(12, 180);
            this.l_gebdatum.Name = "l_gebdatum";
            this.l_gebdatum.Size = new System.Drawing.Size(73, 13);
            this.l_gebdatum.TabIndex = 7;
            this.l_gebdatum.Text = "Geburtsdatum";
            // 
            // l_header
            // 
            this.l_header.AutoSize = true;
            this.l_header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.l_header.Location = new System.Drawing.Point(12, 9);
            this.l_header.Name = "l_header";
            this.l_header.Size = new System.Drawing.Size(66, 13);
            this.l_header.TabIndex = 8;
            this.l_header.Text = "Spielerdaten";
            // 
            // bezeichnung
            // 
            this.bezeichnung.Enabled = false;
            this.bezeichnung.Location = new System.Drawing.Point(15, 293);
            this.bezeichnung.Name = "bezeichnung";
            this.bezeichnung.Size = new System.Drawing.Size(253, 20);
            this.bezeichnung.TabIndex = 9;
            this.bezeichnung.TextChanged += new System.EventHandler(this.bezeichnung_TextChanged);
            // 
            // l_bezeichnung
            // 
            this.l_bezeichnung.AutoSize = true;
            this.l_bezeichnung.Location = new System.Drawing.Point(12, 277);
            this.l_bezeichnung.Name = "l_bezeichnung";
            this.l_bezeichnung.Size = new System.Drawing.Size(69, 13);
            this.l_bezeichnung.TabIndex = 10;
            this.l_bezeichnung.Text = "Bezeichnung";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Erzeugen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(301, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // b_bild
            // 
            this.b_bild.Location = new System.Drawing.Point(301, 192);
            this.b_bild.Name = "b_bild";
            this.b_bild.Size = new System.Drawing.Size(75, 23);
            this.b_bild.TabIndex = 13;
            this.b_bild.Text = "Bild laden";
            this.b_bild.UseVisualStyleBackColor = true;
            this.b_bild.Click += new System.EventHandler(this.b_bild_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(15, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Bild Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Beenden";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(274, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 131);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(506, 415);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.b_bild);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_bezeichnung);
            this.Controls.Add(this.bezeichnung);
            this.Controls.Add(this.l_header);
            this.Controls.Add(this.l_gebdatum);
            this.Controls.Add(this.gebdatum);
            this.Controls.Add(this.l_kunstlername);
            this.Controls.Add(this.kunstlername);
            this.Controls.Add(this.l_nachname);
            this.Controls.Add(this.nachname);
            this.Controls.Add(this.l_vorname);
            this.Controls.Add(this.vorname);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Spielerbilder Benennung";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vorname;
        private System.Windows.Forms.Label l_vorname;
        private System.Windows.Forms.Label l_nachname;
        private System.Windows.Forms.TextBox nachname;
        private System.Windows.Forms.Label l_kunstlername;
        private System.Windows.Forms.TextBox kunstlername;
        private System.Windows.Forms.DateTimePicker gebdatum;
        private System.Windows.Forms.Label l_gebdatum;
        private System.Windows.Forms.Label l_header;
        private System.Windows.Forms.TextBox bezeichnung;
        private System.Windows.Forms.Label l_bezeichnung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_bild;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

