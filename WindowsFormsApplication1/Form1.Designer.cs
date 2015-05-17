namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_emetteur = new System.Windows.Forms.Label();
            this.lbl_destinataire = new System.Windows.Forms.Label();
            this.lbl_cc = new System.Windows.Forms.Label();
            this.lbl_objet = new System.Windows.Forms.Label();
            this.lbl_pj = new System.Windows.Forms.Label();
            this.txt_corps = new System.Windows.Forms.RichTextBox();
            this.listPJ = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_voice = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb_splash = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_categ = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_recherche = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_outlook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_splash)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 490);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(183)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 663);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Importer des mails";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_emetteur
            // 
            this.lbl_emetteur.AutoSize = true;
            this.lbl_emetteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emetteur.Location = new System.Drawing.Point(313, 174);
            this.lbl_emetteur.Name = "lbl_emetteur";
            this.lbl_emetteur.Size = new System.Drawing.Size(0, 20);
            this.lbl_emetteur.TabIndex = 3;
            // 
            // lbl_destinataire
            // 
            this.lbl_destinataire.AutoSize = true;
            this.lbl_destinataire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_destinataire.Location = new System.Drawing.Point(313, 205);
            this.lbl_destinataire.Name = "lbl_destinataire";
            this.lbl_destinataire.Size = new System.Drawing.Size(0, 20);
            this.lbl_destinataire.TabIndex = 4;
            // 
            // lbl_cc
            // 
            this.lbl_cc.AutoSize = true;
            this.lbl_cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cc.Location = new System.Drawing.Point(313, 237);
            this.lbl_cc.Name = "lbl_cc";
            this.lbl_cc.Size = new System.Drawing.Size(0, 20);
            this.lbl_cc.TabIndex = 5;
            // 
            // lbl_objet
            // 
            this.lbl_objet.AutoSize = true;
            this.lbl_objet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_objet.Location = new System.Drawing.Point(313, 290);
            this.lbl_objet.Name = "lbl_objet";
            this.lbl_objet.Size = new System.Drawing.Size(0, 20);
            this.lbl_objet.TabIndex = 6;
            // 
            // lbl_pj
            // 
            this.lbl_pj.AutoSize = true;
            this.lbl_pj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pj.Location = new System.Drawing.Point(238, 637);
            this.lbl_pj.Name = "lbl_pj";
            this.lbl_pj.Size = new System.Drawing.Size(0, 20);
            this.lbl_pj.TabIndex = 8;
            // 
            // txt_corps
            // 
            this.txt_corps.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_corps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_corps.Location = new System.Drawing.Point(317, 346);
            this.txt_corps.Name = "txt_corps";
            this.txt_corps.Size = new System.Drawing.Size(854, 250);
            this.txt_corps.TabIndex = 9;
            this.txt_corps.Text = "";
            // 
            // listPJ
            // 
            this.listPJ.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listPJ.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listPJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPJ.LargeImageList = this.imageList1;
            this.listPJ.Location = new System.Drawing.Point(317, 609);
            this.listPJ.MultiSelect = false;
            this.listPJ.Name = "listPJ";
            this.listPJ.Size = new System.Drawing.Size(729, 106);
            this.listPJ.TabIndex = 10;
            this.listPJ.UseCompatibleStateImageBehavior = false;
            this.listPJ.SelectedIndexChanged += new System.EventHandler(this.listPJ_SelectedIndexChanged);
            this.listPJ.DoubleClick += new System.EventHandler(this.listPJ_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "file_type_icons_flat_-01.png");
            this.imageList1.Images.SetKeyName(1, "file_type_icons_flat_-02.png");
            this.imageList1.Images.SetKeyName(2, "file_type_icons_flat_-03.png");
            this.imageList1.Images.SetKeyName(3, "file_type_icons_flat_-04.png");
            this.imageList1.Images.SetKeyName(4, "file_type_icons_flat_-05.png");
            this.imageList1.Images.SetKeyName(5, "file_type_icons_flat_-06.png");
            this.imageList1.Images.SetKeyName(6, "file_type_icons_flat_-07.png");
            this.imageList1.Images.SetKeyName(7, "file_type_icons_flat_-08.png");
            this.imageList1.Images.SetKeyName(8, "file_type_icons_flat_-09.png");
            this.imageList1.Images.SetKeyName(9, "file_type_icons_flat_-10.png");
            this.imageList1.Images.SetKeyName(10, "file_type_icons_flat_-11.png");
            this.imageList1.Images.SetKeyName(11, "file_type_icons_flat_-12.png");
            this.imageList1.Images.SetKeyName(12, "file_type_icons_flat_-13.png");
            this.imageList1.Images.SetKeyName(13, "file_type_icons_flat_-14.png");
            this.imageList1.Images.SetKeyName(14, "file_type_icons_flat_-15.png");
            this.imageList1.Images.SetKeyName(15, "file_type_icons_flat_-16.png");
            this.imageList1.Images.SetKeyName(16, "file_type_icons_flat_-17.png");
            this.imageList1.Images.SetKeyName(17, "file_type_icons_flat_-18.png");
            this.imageList1.Images.SetKeyName(18, "file_type_icons_flat_-19.png");
            this.imageList1.Images.SetKeyName(19, "file_type_icons_flat_-20.png");
            this.imageList1.Images.SetKeyName(20, "file_type_icons_flat_-21.png");
            this.imageList1.Images.SetKeyName(21, "file_type_icons_flat_-22.png");
            this.imageList1.Images.SetKeyName(22, "file_type_icons_flat_-23.png");
            this.imageList1.Images.SetKeyName(23, "file_type_icons_flat_-24.png");
            this.imageList1.Images.SetKeyName(24, "file_type_icons_flat_-25.png");
            this.imageList1.Images.SetKeyName(25, "file_type_icons_flat_-26.png");
            this.imageList1.Images.SetKeyName(26, "file_type_icons_flat_-27.png");
            this.imageList1.Images.SetKeyName(27, "file_type_icons_flat_-28.png");
            this.imageList1.Images.SetKeyName(28, "file_type_icons_flat_-29.png");
            this.imageList1.Images.SetKeyName(29, "file_type_icons_flat_-30.png");
            // 
            // btn_voice
            // 
            this.btn_voice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(183)))));
            this.btn_voice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_voice.Location = new System.Drawing.Point(1067, 609);
            this.btn_voice.Name = "btn_voice";
            this.btn_voice.Size = new System.Drawing.Size(104, 97);
            this.btn_voice.TabIndex = 11;
            this.btn_voice.Text = "Start / Stop Voix";
            this.btn_voice.UseVisualStyleBackColor = false;
            this.btn_voice.Click += new System.EventHandler(this.btn_voice_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb_splash
            // 
            this.pb_splash.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.outlook_spalsh;
            this.pb_splash.Image = global::WindowsFormsApplication1.Properties.Resources.outlook_spalsh1;
            this.pb_splash.Location = new System.Drawing.Point(0, 0);
            this.pb_splash.Name = "pb_splash";
            this.pb_splash.Size = new System.Drawing.Size(1202, 718);
            this.pb_splash.TabIndex = 12;
            this.pb_splash.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.outlook2;
            this.panel1.Controls.Add(this.cmb_categ);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_recherche);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_outlook);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 148);
            this.panel1.TabIndex = 0;
            // 
            // cmb_categ
            // 
            this.cmb_categ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categ.FormattingEnabled = true;
            this.cmb_categ.Items.AddRange(new object[] {
            "EMETTEUR",
            "DESTINATAIRE",
            "OBJET",
            "CORPS"});
            this.cmb_categ.Location = new System.Drawing.Point(1057, 79);
            this.cmb_categ.Name = "cmb_categ";
            this.cmb_categ.Size = new System.Drawing.Size(123, 21);
            this.cmb_categ.TabIndex = 12;
            this.cmb_categ.SelectedIndexChanged += new System.EventHandler(this.cmb_categ_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(183)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(952, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Recherche :";
            // 
            // txt_recherche
            // 
            this.txt_recherche.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_recherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txt_recherche.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_recherche.Location = new System.Drawing.Point(956, 109);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.Size = new System.Drawing.Size(224, 26);
            this.txt_recherche.TabIndex = 10;
            this.txt_recherche.TextChanged += new System.EventHandler(this.txt_recherche_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(183)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(183)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(162, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client léger pour la lecture de mails";
            // 
            // lbl_outlook
            // 
            this.lbl_outlook.AutoSize = true;
            this.lbl_outlook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(183)))));
            this.lbl_outlook.Font = new System.Drawing.Font("Segoe UI", 24.25F);
            this.lbl_outlook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_outlook.Location = new System.Drawing.Point(159, 34);
            this.lbl_outlook.Name = "lbl_outlook";
            this.lbl_outlook.Size = new System.Drawing.Size(327, 45);
            this.lbl_outlook.TabIndex = 0;
            this.lbl_outlook.Text = "Outlook RapidViewer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1202, 718);
            this.Controls.Add(this.pb_splash);
            this.Controls.Add(this.btn_voice);
            this.Controls.Add(this.listPJ);
            this.Controls.Add(this.txt_corps);
            this.Controls.Add(this.lbl_pj);
            this.Controls.Add(this.lbl_objet);
            this.Controls.Add(this.lbl_cc);
            this.Controls.Add(this.lbl_destinataire);
            this.Controls.Add(this.lbl_emetteur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_splash)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_outlook;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_emetteur;
        private System.Windows.Forms.Label lbl_destinataire;
        private System.Windows.Forms.Label lbl_cc;
        private System.Windows.Forms.Label lbl_objet;
        private System.Windows.Forms.Label lbl_pj;
        private System.Windows.Forms.RichTextBox txt_corps;
        private System.Windows.Forms.TextBox txt_recherche;
        private System.Windows.Forms.ComboBox cmb_categ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listPJ;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_voice;
        private System.Windows.Forms.PictureBox pb_splash;
        private System.Windows.Forms.Timer timer1;
    }
}

