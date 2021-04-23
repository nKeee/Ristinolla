namespace Harjoitustyö
{
    partial class Ristinolla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ristinolla));
            this.menuStrippi = new System.Windows.Forms.MenuStrip();
            this.aloitusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiPeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.säännötToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.X_Voitot = new System.Windows.Forms.Label();
            this.O_Voitot = new System.Windows.Forms.Label();
            this.label_tasapelit = new System.Windows.Forms.Label();
            this.Tasurimaara = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Panel();
            this.A2 = new System.Windows.Forms.Panel();
            this.A3 = new System.Windows.Forms.Panel();
            this.B1 = new System.Windows.Forms.Panel();
            this.B2 = new System.Windows.Forms.Panel();
            this.B3 = new System.Windows.Forms.Panel();
            this.C1 = new System.Windows.Forms.Panel();
            this.C2 = new System.Windows.Forms.Panel();
            this.C3 = new System.Windows.Forms.Panel();
            this.label_x = new System.Windows.Forms.Label();
            this.label_o = new System.Windows.Forms.Label();
            this.tb_pelaaja1 = new System.Windows.Forms.TextBox();
            this.tb_pelaaja2 = new System.Windows.Forms.TextBox();
            this.dgvPelaajat = new System.Windows.Forms.DataGridView();
            this.tabit_kaikki = new System.Windows.Forms.TabControl();
            this.tab_peli = new System.Windows.Forms.TabPage();
            this.progbar_ai = new System.Windows.Forms.ProgressBar();
            this.tab_profiilit = new System.Windows.Forms.TabPage();
            this.cbox_tietokoneohjaus = new System.Windows.Forms.CheckBox();
            this.bt_tallenna = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_uusinimi = new System.Windows.Forms.TextBox();
            this.btn_valitse_2 = new System.Windows.Forms.Button();
            this.btn_poista = new System.Windows.Forms.Button();
            this.btn_valitse_1 = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.ajastin = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrippi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelaajat)).BeginInit();
            this.tabit_kaikki.SuspendLayout();
            this.tab_peli.SuspendLayout();
            this.tab_profiilit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrippi
            // 
            this.menuStrippi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aloitusToolStripMenuItem,
            this.apuaToolStripMenuItem});
            this.menuStrippi.Location = new System.Drawing.Point(0, 0);
            this.menuStrippi.Name = "menuStrippi";
            this.menuStrippi.Size = new System.Drawing.Size(545, 24);
            this.menuStrippi.TabIndex = 0;
            this.menuStrippi.Text = "menuStrip1";
            // 
            // aloitusToolStripMenuItem
            // 
            this.aloitusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiPeliToolStripMenuItem,
            this.suljeToolStripMenuItem});
            this.aloitusToolStripMenuItem.Name = "aloitusToolStripMenuItem";
            this.aloitusToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aloitusToolStripMenuItem.Text = "Aloita";
            this.aloitusToolStripMenuItem.Click += new System.EventHandler(this.aloitusToolStripMenuItem_Click);
            // 
            // uusiPeliToolStripMenuItem
            // 
            this.uusiPeliToolStripMenuItem.Name = "uusiPeliToolStripMenuItem";
            this.uusiPeliToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.uusiPeliToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.uusiPeliToolStripMenuItem.Text = "Uusi peli";
            this.uusiPeliToolStripMenuItem.Click += new System.EventHandler(this.uusiPeliToolStripMenuItem_Click);
            // 
            // suljeToolStripMenuItem
            // 
            this.suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            this.suljeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.suljeToolStripMenuItem.Text = "Sulje";
            this.suljeToolStripMenuItem.Click += new System.EventHandler(this.suljeToolStripMenuItem_Click);
            // 
            // apuaToolStripMenuItem
            // 
            this.apuaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.säännötToolStripMenuItem,
            this.tietojaToolStripMenuItem});
            this.apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            this.apuaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.apuaToolStripMenuItem.Text = "Apua";
            // 
            // säännötToolStripMenuItem
            // 
            this.säännötToolStripMenuItem.Name = "säännötToolStripMenuItem";
            this.säännötToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.säännötToolStripMenuItem.Text = "Säännöt";
            this.säännötToolStripMenuItem.Click += new System.EventHandler(this.säännötToolStripMenuItem_Click);
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            this.tietojaToolStripMenuItem.Click += new System.EventHandler(this.tietojaToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "kuvake.png");
            this.imageList1.Images.SetKeyName(1, "Nimetön.png");
            this.imageList1.Images.SetKeyName(2, "tyhja.png");
            // 
            // X_Voitot
            // 
            this.X_Voitot.AutoSize = true;
            this.X_Voitot.Location = new System.Drawing.Point(131, 95);
            this.X_Voitot.Name = "X_Voitot";
            this.X_Voitot.Size = new System.Drawing.Size(13, 13);
            this.X_Voitot.TabIndex = 15;
            this.X_Voitot.Text = "0";
            // 
            // O_Voitot
            // 
            this.O_Voitot.AutoSize = true;
            this.O_Voitot.Location = new System.Drawing.Point(344, 95);
            this.O_Voitot.Name = "O_Voitot";
            this.O_Voitot.Size = new System.Drawing.Size(13, 13);
            this.O_Voitot.TabIndex = 16;
            this.O_Voitot.Text = "0";
            // 
            // label_tasapelit
            // 
            this.label_tasapelit.AutoSize = true;
            this.label_tasapelit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tasapelit.Location = new System.Drawing.Point(207, 63);
            this.label_tasapelit.Name = "label_tasapelit";
            this.label_tasapelit.Size = new System.Drawing.Size(75, 17);
            this.label_tasapelit.TabIndex = 17;
            this.label_tasapelit.Text = "Tasapelit";
            // 
            // Tasurimaara
            // 
            this.Tasurimaara.AutoSize = true;
            this.Tasurimaara.Location = new System.Drawing.Point(234, 95);
            this.Tasurimaara.Name = "Tasurimaara";
            this.Tasurimaara.Size = new System.Drawing.Size(13, 13);
            this.Tasurimaara.TabIndex = 18;
            this.Tasurimaara.Text = "0";
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.SystemColors.Window;
            this.A1.Location = new System.Drawing.Point(89, 130);
            this.A1.MaximumSize = new System.Drawing.Size(100, 100);
            this.A1.MinimumSize = new System.Drawing.Size(100, 100);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 100);
            this.A1.TabIndex = 31;
            this.A1.Click += new System.EventHandler(this.klikkaus);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.SystemColors.Window;
            this.A2.Location = new System.Drawing.Point(195, 130);
            this.A2.MaximumSize = new System.Drawing.Size(100, 100);
            this.A2.MinimumSize = new System.Drawing.Size(100, 100);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 100);
            this.A2.TabIndex = 32;
            this.A2.Click += new System.EventHandler(this.klikkaus);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.SystemColors.Window;
            this.A3.Location = new System.Drawing.Point(301, 130);
            this.A3.MaximumSize = new System.Drawing.Size(100, 100);
            this.A3.MinimumSize = new System.Drawing.Size(100, 100);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 100);
            this.A3.TabIndex = 33;
            this.A3.Click += new System.EventHandler(this.klikkaus);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.Window;
            this.B1.Location = new System.Drawing.Point(89, 236);
            this.B1.MaximumSize = new System.Drawing.Size(100, 100);
            this.B1.MinimumSize = new System.Drawing.Size(100, 100);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 100);
            this.B1.TabIndex = 34;
            this.B1.Click += new System.EventHandler(this.klikkaus);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.Window;
            this.B2.Location = new System.Drawing.Point(195, 236);
            this.B2.MaximumSize = new System.Drawing.Size(100, 100);
            this.B2.MinimumSize = new System.Drawing.Size(100, 100);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 100);
            this.B2.TabIndex = 35;
            this.B2.Click += new System.EventHandler(this.klikkaus);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.Window;
            this.B3.Location = new System.Drawing.Point(301, 236);
            this.B3.MaximumSize = new System.Drawing.Size(100, 100);
            this.B3.MinimumSize = new System.Drawing.Size(100, 100);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 100);
            this.B3.TabIndex = 36;
            this.B3.Click += new System.EventHandler(this.klikkaus);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.SystemColors.Window;
            this.C1.Location = new System.Drawing.Point(89, 342);
            this.C1.MaximumSize = new System.Drawing.Size(100, 100);
            this.C1.MinimumSize = new System.Drawing.Size(100, 100);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 100);
            this.C1.TabIndex = 37;
            this.C1.Click += new System.EventHandler(this.klikkaus);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.SystemColors.Window;
            this.C2.Location = new System.Drawing.Point(195, 342);
            this.C2.MaximumSize = new System.Drawing.Size(100, 100);
            this.C2.MinimumSize = new System.Drawing.Size(100, 100);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 100);
            this.C2.TabIndex = 38;
            this.C2.Click += new System.EventHandler(this.klikkaus);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.SystemColors.Window;
            this.C3.Location = new System.Drawing.Point(301, 342);
            this.C3.MaximumSize = new System.Drawing.Size(100, 100);
            this.C3.MinimumSize = new System.Drawing.Size(100, 100);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 100);
            this.C3.TabIndex = 39;
            this.C3.Click += new System.EventHandler(this.klikkaus);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x.Location = new System.Drawing.Point(123, 27);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(30, 29);
            this.label_x.TabIndex = 40;
            this.label_x.Text = "X";
            // 
            // label_o
            // 
            this.label_o.AutoSize = true;
            this.label_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_o.Location = new System.Drawing.Point(335, 27);
            this.label_o.Name = "label_o";
            this.label_o.Size = new System.Drawing.Size(32, 29);
            this.label_o.TabIndex = 41;
            this.label_o.Text = "O";
            // 
            // tb_pelaaja1
            // 
            this.tb_pelaaja1.Location = new System.Drawing.Point(89, 63);
            this.tb_pelaaja1.Name = "tb_pelaaja1";
            this.tb_pelaaja1.ReadOnly = true;
            this.tb_pelaaja1.Size = new System.Drawing.Size(100, 20);
            this.tb_pelaaja1.TabIndex = 43;
            // 
            // tb_pelaaja2
            // 
            this.tb_pelaaja2.Location = new System.Drawing.Point(301, 63);
            this.tb_pelaaja2.Name = "tb_pelaaja2";
            this.tb_pelaaja2.ReadOnly = true;
            this.tb_pelaaja2.Size = new System.Drawing.Size(100, 20);
            this.tb_pelaaja2.TabIndex = 44;
            // 
            // dgvPelaajat
            // 
            this.dgvPelaajat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelaajat.Location = new System.Drawing.Point(6, 6);
            this.dgvPelaajat.Name = "dgvPelaajat";
            this.dgvPelaajat.ReadOnly = true;
            this.dgvPelaajat.Size = new System.Drawing.Size(501, 386);
            this.dgvPelaajat.TabIndex = 45;
            // 
            // tabit_kaikki
            // 
            this.tabit_kaikki.Controls.Add(this.tab_peli);
            this.tabit_kaikki.Controls.Add(this.tab_profiilit);
            this.tabit_kaikki.Location = new System.Drawing.Point(12, 27);
            this.tabit_kaikki.Name = "tabit_kaikki";
            this.tabit_kaikki.SelectedIndex = 0;
            this.tabit_kaikki.Size = new System.Drawing.Size(523, 546);
            this.tabit_kaikki.TabIndex = 47;
            this.tabit_kaikki.TabIndexChanged += new System.EventHandler(this.tabit_kaikki_TabIndexChanged);
            this.tabit_kaikki.Click += new System.EventHandler(this.tabit_kaikki_Click);
            // 
            // tab_peli
            // 
            this.tab_peli.BackColor = System.Drawing.Color.Silver;
            this.tab_peli.Controls.Add(this.progbar_ai);
            this.tab_peli.Controls.Add(this.label_tasapelit);
            this.tab_peli.Controls.Add(this.X_Voitot);
            this.tab_peli.Controls.Add(this.O_Voitot);
            this.tab_peli.Controls.Add(this.tb_pelaaja2);
            this.tab_peli.Controls.Add(this.Tasurimaara);
            this.tab_peli.Controls.Add(this.tb_pelaaja1);
            this.tab_peli.Controls.Add(this.A1);
            this.tab_peli.Controls.Add(this.A2);
            this.tab_peli.Controls.Add(this.label_o);
            this.tab_peli.Controls.Add(this.A3);
            this.tab_peli.Controls.Add(this.label_x);
            this.tab_peli.Controls.Add(this.B1);
            this.tab_peli.Controls.Add(this.C3);
            this.tab_peli.Controls.Add(this.B2);
            this.tab_peli.Controls.Add(this.C2);
            this.tab_peli.Controls.Add(this.B3);
            this.tab_peli.Controls.Add(this.C1);
            this.tab_peli.Location = new System.Drawing.Point(4, 22);
            this.tab_peli.Name = "tab_peli";
            this.tab_peli.Padding = new System.Windows.Forms.Padding(3);
            this.tab_peli.Size = new System.Drawing.Size(515, 520);
            this.tab_peli.TabIndex = 0;
            this.tab_peli.Text = "Peli";
            // 
            // progbar_ai
            // 
            this.progbar_ai.Location = new System.Drawing.Point(89, 460);
            this.progbar_ai.Name = "progbar_ai";
            this.progbar_ai.Size = new System.Drawing.Size(312, 23);
            this.progbar_ai.TabIndex = 48;
            // 
            // tab_profiilit
            // 
            this.tab_profiilit.Controls.Add(this.panel1);
            this.tab_profiilit.Controls.Add(this.btn_valitse_2);
            this.tab_profiilit.Controls.Add(this.btn_poista);
            this.tab_profiilit.Controls.Add(this.btn_valitse_1);
            this.tab_profiilit.Controls.Add(this.dgvPelaajat);
            this.tab_profiilit.Location = new System.Drawing.Point(4, 22);
            this.tab_profiilit.Name = "tab_profiilit";
            this.tab_profiilit.Padding = new System.Windows.Forms.Padding(3);
            this.tab_profiilit.Size = new System.Drawing.Size(515, 520);
            this.tab_profiilit.TabIndex = 1;
            this.tab_profiilit.Text = "Profiilit";
            this.tab_profiilit.UseVisualStyleBackColor = true;
            // 
            // cbox_tietokoneohjaus
            // 
            this.cbox_tietokoneohjaus.AutoSize = true;
            this.cbox_tietokoneohjaus.Location = new System.Drawing.Point(26, 59);
            this.cbox_tietokoneohjaus.Name = "cbox_tietokoneohjaus";
            this.cbox_tietokoneohjaus.Size = new System.Drawing.Size(142, 17);
            this.cbox_tietokoneohjaus.TabIndex = 52;
            this.cbox_tietokoneohjaus.Text = "Tekoälyn ohjaama profiili";
            this.cbox_tietokoneohjaus.UseVisualStyleBackColor = true;
            // 
            // bt_tallenna
            // 
            this.bt_tallenna.BackColor = System.Drawing.Color.Transparent;
            this.bt_tallenna.Location = new System.Drawing.Point(52, 86);
            this.bt_tallenna.Name = "bt_tallenna";
            this.bt_tallenna.Size = new System.Drawing.Size(100, 24);
            this.bt_tallenna.TabIndex = 51;
            this.bt_tallenna.Text = "Luo uusi profiili";
            this.bt_tallenna.UseVisualStyleBackColor = false;
            this.bt_tallenna.Click += new System.EventHandler(this.bt_tallenna_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Uuden profiilin nimi :";
            // 
            // tb_uusinimi
            // 
            this.tb_uusinimi.Location = new System.Drawing.Point(109, 33);
            this.tb_uusinimi.Name = "tb_uusinimi";
            this.tb_uusinimi.Size = new System.Drawing.Size(100, 20);
            this.tb_uusinimi.TabIndex = 49;
            // 
            // btn_valitse_2
            // 
            this.btn_valitse_2.Location = new System.Drawing.Point(141, 398);
            this.btn_valitse_2.Name = "btn_valitse_2";
            this.btn_valitse_2.Size = new System.Drawing.Size(115, 65);
            this.btn_valitse_2.TabIndex = 48;
            this.btn_valitse_2.Text = "Valitse Pelaaja2";
            this.btn_valitse_2.UseVisualStyleBackColor = true;
            this.btn_valitse_2.Click += new System.EventHandler(this.btn_valitse_2_Click);
            // 
            // btn_poista
            // 
            this.btn_poista.Location = new System.Drawing.Point(76, 484);
            this.btn_poista.Name = "btn_poista";
            this.btn_poista.Size = new System.Drawing.Size(114, 30);
            this.btn_poista.TabIndex = 47;
            this.btn_poista.Text = "Poista valittu profiili";
            this.btn_poista.UseVisualStyleBackColor = true;
            this.btn_poista.Click += new System.EventHandler(this.btn_poista_Click);
            // 
            // btn_valitse_1
            // 
            this.btn_valitse_1.Location = new System.Drawing.Point(8, 398);
            this.btn_valitse_1.Name = "btn_valitse_1";
            this.btn_valitse_1.Size = new System.Drawing.Size(117, 65);
            this.btn_valitse_1.TabIndex = 46;
            this.btn_valitse_1.Text = "Valitse Pelaaja1";
            this.btn_valitse_1.UseVisualStyleBackColor = true;
            this.btn_valitse_1.Click += new System.EventHandler(this.btn_valitse_1_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.TableName = "Table1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bt_tallenna);
            this.panel1.Controls.Add(this.cbox_tietokoneohjaus);
            this.panel1.Controls.Add(this.tb_uusinimi);
            this.panel1.Location = new System.Drawing.Point(287, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 116);
            this.panel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "UUDEN PROFIILIN LUONTI";
            // 
            // Ristinolla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 575);
            this.Controls.Add(this.tabit_kaikki);
            this.Controls.Add(this.menuStrippi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrippi;
            this.MaximumSize = new System.Drawing.Size(561, 614);
            this.MinimumSize = new System.Drawing.Size(561, 614);
            this.Name = "Ristinolla";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ristinolla 0.01";
            this.menuStrippi.ResumeLayout(false);
            this.menuStrippi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelaajat)).EndInit();
            this.tabit_kaikki.ResumeLayout(false);
            this.tab_peli.ResumeLayout(false);
            this.tab_peli.PerformLayout();
            this.tab_profiilit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrippi;
        private System.Windows.Forms.ToolStripMenuItem aloitusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem säännötToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uusiPeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suljeToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label X_Voitot;
        private System.Windows.Forms.Label O_Voitot;
        private System.Windows.Forms.Label label_tasapelit;
        private System.Windows.Forms.Label Tasurimaara;
        private System.Windows.Forms.Panel A1;
        private System.Windows.Forms.Panel A2;
        private System.Windows.Forms.Panel A3;
        private System.Windows.Forms.Panel B1;
        private System.Windows.Forms.Panel B2;
        private System.Windows.Forms.Panel B3;
        private System.Windows.Forms.Panel C1;
        private System.Windows.Forms.Panel C2;
        private System.Windows.Forms.Panel C3;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_o;
        private System.Windows.Forms.TextBox tb_pelaaja1;
        private System.Windows.Forms.TextBox tb_pelaaja2;
        private System.Windows.Forms.DataGridView dgvPelaajat;
        private System.Windows.Forms.TabControl tabit_kaikki;
        private System.Windows.Forms.TabPage tab_peli;
        private System.Windows.Forms.TabPage tab_profiilit;
        private System.Windows.Forms.Button btn_valitse_2;
        private System.Windows.Forms.Button btn_poista;
        private System.Windows.Forms.Button btn_valitse_1;
        private System.Windows.Forms.CheckBox cbox_tietokoneohjaus;
        private System.Windows.Forms.Button bt_tallenna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_uusinimi;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Windows.Forms.Timer ajastin;
        private System.Windows.Forms.ProgressBar progbar_ai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

