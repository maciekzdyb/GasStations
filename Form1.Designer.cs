namespace _3CityPetrol
{
    partial class Form1
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
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btnAllStations = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxTrasa = new System.Windows.Forms.GroupBox();
            this.checkBoxStacja = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearLatLon = new System.Windows.Forms.Button();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDystans = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLonStop = new System.Windows.Forms.TextBox();
            this.textBoxLatStop = new System.Windows.Forms.TextBox();
            this.textBoxLonStart = new System.Windows.Forms.TextBox();
            this.textBoxLatStart = new System.Windows.Forms.TextBox();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeProvider = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectnazwa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxGasName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnUsunStacje = new System.Windows.Forms.Button();
            this.textBoxLon = new System.Windows.Forms.TextBox();
            this.textBoxLat = new System.Windows.Forms.TextBox();
            this.textBoxCena95 = new System.Windows.Forms.TextBox();
            this.textBoxCenaD = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.btnDodajStacje = new System.Windows.Forms.Button();
            this.btnUaktualnij = new System.Windows.Forms.Button();
            this.groupBoxTrasa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(12, 13);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 30;
            this.gmap.MinZoom = 1;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(623, 610);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 0D;
            this.gmap.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.gmap_OnMarkerEnter);
            this.gmap.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.gmap_OnMarkerLeave);
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            this.gmap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseDoubleClick);
            // 
            // btnAllStations
            // 
            this.btnAllStations.Location = new System.Drawing.Point(6, 37);
            this.btnAllStations.Name = "btnAllStations";
            this.btnAllStations.Size = new System.Drawing.Size(102, 23);
            this.btnAllStations.TabIndex = 1;
            this.btnAllStations.Text = "wszystkie stacje";
            this.btnAllStations.UseVisualStyleBackColor = true;
            this.btnAllStations.Click += new System.EventHandler(this.btnAllStations_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(112, 71);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Wyczyść mapę";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBoxTrasa
            // 
            this.groupBoxTrasa.Controls.Add(this.checkBoxStacja);
            this.groupBoxTrasa.Controls.Add(this.label5);
            this.groupBoxTrasa.Controls.Add(this.btnClearLatLon);
            this.groupBoxTrasa.Controls.Add(this.btnOblicz);
            this.groupBoxTrasa.Controls.Add(this.label4);
            this.groupBoxTrasa.Controls.Add(this.textBoxDystans);
            this.groupBoxTrasa.Controls.Add(this.label3);
            this.groupBoxTrasa.Controls.Add(this.label2);
            this.groupBoxTrasa.Controls.Add(this.textBoxLonStop);
            this.groupBoxTrasa.Controls.Add(this.textBoxLatStop);
            this.groupBoxTrasa.Controls.Add(this.textBoxLonStart);
            this.groupBoxTrasa.Controls.Add(this.textBoxLatStart);
            this.groupBoxTrasa.Location = new System.Drawing.Point(642, 99);
            this.groupBoxTrasa.Name = "groupBoxTrasa";
            this.groupBoxTrasa.Size = new System.Drawing.Size(235, 207);
            this.groupBoxTrasa.TabIndex = 5;
            this.groupBoxTrasa.TabStop = false;
            this.groupBoxTrasa.Text = "trasa";
            // 
            // checkBoxStacja
            // 
            this.checkBoxStacja.AutoSize = true;
            this.checkBoxStacja.Location = new System.Drawing.Point(34, 19);
            this.checkBoxStacja.Name = "checkBoxStacja";
            this.checkBoxStacja.Size = new System.Drawing.Size(102, 17);
            this.checkBoxStacja.TabIndex = 13;
            this.checkBoxStacja.Text = "najbliższa stacja";
            this.checkBoxStacja.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "km";
            // 
            // btnClearLatLon
            // 
            this.btnClearLatLon.Location = new System.Drawing.Point(119, 145);
            this.btnClearLatLon.Name = "btnClearLatLon";
            this.btnClearLatLon.Size = new System.Drawing.Size(75, 23);
            this.btnClearLatLon.TabIndex = 11;
            this.btnClearLatLon.Text = "Wyczyść";
            this.btnClearLatLon.UseVisualStyleBackColor = true;
            this.btnClearLatLon.Click += new System.EventHandler(this.btnClearLatLon_Click);
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(7, 145);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(75, 23);
            this.btnOblicz.TabIndex = 10;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "dystans:";
            // 
            // textBoxDystans
            // 
            this.textBoxDystans.Location = new System.Drawing.Point(88, 181);
            this.textBoxDystans.Name = "textBoxDystans";
            this.textBoxDystans.ReadOnly = true;
            this.textBoxDystans.Size = new System.Drawing.Size(79, 20);
            this.textBoxDystans.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "koniec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "początek";
            // 
            // textBoxLonStop
            // 
            this.textBoxLonStop.Location = new System.Drawing.Point(94, 119);
            this.textBoxLonStop.Name = "textBoxLonStop";
            this.textBoxLonStop.ReadOnly = true;
            this.textBoxLonStop.Size = new System.Drawing.Size(100, 20);
            this.textBoxLonStop.TabIndex = 3;
            // 
            // textBoxLatStop
            // 
            this.textBoxLatStop.Location = new System.Drawing.Point(94, 93);
            this.textBoxLatStop.Name = "textBoxLatStop";
            this.textBoxLatStop.ReadOnly = true;
            this.textBoxLatStop.Size = new System.Drawing.Size(100, 20);
            this.textBoxLatStop.TabIndex = 2;
            // 
            // textBoxLonStart
            // 
            this.textBoxLonStart.Location = new System.Drawing.Point(94, 67);
            this.textBoxLonStart.Name = "textBoxLonStart";
            this.textBoxLonStart.ReadOnly = true;
            this.textBoxLonStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxLonStart.TabIndex = 1;
            // 
            // textBoxLatStart
            // 
            this.textBoxLatStart.Location = new System.Drawing.Point(94, 41);
            this.textBoxLatStart.Name = "textBoxLatStart";
            this.textBoxLatStart.ReadOnly = true;
            this.textBoxLatStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxLatStart.TabIndex = 0;
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Items.AddRange(new object[] {
            "Google",
            "Bing",
            "OpenStreet"});
            this.comboBoxProvider.Location = new System.Drawing.Point(97, 19);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProvider.TabIndex = 7;
            this.comboBoxProvider.Tag = "";
            this.comboBoxProvider.Text = "Google";
            this.comboBoxProvider.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvider_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dostawca usługi";
            // 
            // btnChangeProvider
            // 
            this.btnChangeProvider.Location = new System.Drawing.Point(6, 55);
            this.btnChangeProvider.Name = "btnChangeProvider";
            this.btnChangeProvider.Size = new System.Drawing.Size(102, 23);
            this.btnChangeProvider.TabIndex = 13;
            this.btnChangeProvider.Text = "Zmień dostawcę";
            this.btnChangeProvider.UseVisualStyleBackColor = true;
            this.btnChangeProvider.Click += new System.EventHandler(this.btnChangeProvider_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Marka";
            // 
            // btnSelectnazwa
            // 
            this.btnSelectnazwa.Location = new System.Drawing.Point(114, 37);
            this.btnSelectnazwa.Name = "btnSelectnazwa";
            this.btnSelectnazwa.Size = new System.Drawing.Size(110, 23);
            this.btnSelectnazwa.TabIndex = 15;
            this.btnSelectnazwa.Text = "Wybrane marki";
            this.btnSelectnazwa.UseVisualStyleBackColor = true;
            this.btnSelectnazwa.Click += new System.EventHandler(this.btnSelectnazwa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSelectnazwa);
            this.groupBox1.Controls.Add(this.comboBoxGasName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAllStations);
            this.groupBox1.Location = new System.Drawing.Point(641, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Markery Stacji";
            // 
            // comboBoxGasName
            // 
            this.comboBoxGasName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxGasName.FormattingEnabled = true;
            this.comboBoxGasName.Location = new System.Drawing.Point(101, 10);
            this.comboBoxGasName.Name = "comboBoxGasName";
            this.comboBoxGasName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGasName.TabIndex = 20;
            this.comboBoxGasName.SelectedIndexChanged += new System.EventHandler(this.comboBoxGasName_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChangeProvider);
            this.groupBox2.Controls.Add(this.comboBoxProvider);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(641, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 84);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mapa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUaktualnij);
            this.groupBox3.Controls.Add(this.btnClearData);
            this.groupBox3.Controls.Add(this.btnUsunStacje);
            this.groupBox3.Controls.Add(this.textBoxLon);
            this.groupBox3.Controls.Add(this.textBoxLat);
            this.groupBox3.Controls.Add(this.textBoxCena95);
            this.groupBox3.Controls.Add(this.textBoxCenaD);
            this.groupBox3.Controls.Add(this.textBoxAdress);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxNazwa);
            this.groupBox3.Controls.Add(this.btnDodajStacje);
            this.groupBox3.Location = new System.Drawing.Point(641, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 204);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Baza Danych";
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(154, 146);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(75, 23);
            this.btnClearData.TabIndex = 14;
            this.btnClearData.Text = "Wyczyść";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnUsunStacje
            // 
            this.btnUsunStacje.Location = new System.Drawing.Point(154, 175);
            this.btnUsunStacje.Name = "btnUsunStacje";
            this.btnUsunStacje.Size = new System.Drawing.Size(75, 23);
            this.btnUsunStacje.TabIndex = 13;
            this.btnUsunStacje.Text = "Usuń stację";
            this.btnUsunStacje.UseVisualStyleBackColor = true;
            this.btnUsunStacje.Click += new System.EventHandler(this.btnUsunStacje_Click);
            // 
            // textBoxLon
            // 
            this.textBoxLon.Location = new System.Drawing.Point(129, 120);
            this.textBoxLon.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxLon.Name = "textBoxLon";
            this.textBoxLon.Size = new System.Drawing.Size(100, 20);
            this.textBoxLon.TabIndex = 12;
            // 
            // textBoxLat
            // 
            this.textBoxLat.Location = new System.Drawing.Point(129, 98);
            this.textBoxLat.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxLat.Name = "textBoxLat";
            this.textBoxLat.Size = new System.Drawing.Size(100, 20);
            this.textBoxLat.TabIndex = 11;
            // 
            // textBoxCena95
            // 
            this.textBoxCena95.Location = new System.Drawing.Point(129, 76);
            this.textBoxCena95.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxCena95.Name = "textBoxCena95";
            this.textBoxCena95.Size = new System.Drawing.Size(100, 20);
            this.textBoxCena95.TabIndex = 10;
            // 
            // textBoxCenaD
            // 
            this.textBoxCenaD.Location = new System.Drawing.Point(129, 54);
            this.textBoxCenaD.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxCenaD.Name = "textBoxCenaD";
            this.textBoxCenaD.Size = new System.Drawing.Size(100, 20);
            this.textBoxCenaD.TabIndex = 9;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(47, 32);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(182, 20);
            this.textBoxAdress.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "lon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "lat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "cena E95";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "cena Diesel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "nazwa";
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(129, 10);
            this.textBoxNazwa.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwa.TabIndex = 1;
            // 
            // btnDodajStacje
            // 
            this.btnDodajStacje.Location = new System.Drawing.Point(7, 146);
            this.btnDodajStacje.Name = "btnDodajStacje";
            this.btnDodajStacje.Size = new System.Drawing.Size(75, 23);
            this.btnDodajStacje.TabIndex = 0;
            this.btnDodajStacje.Text = "Dodaj stację";
            this.btnDodajStacje.UseVisualStyleBackColor = true;
            this.btnDodajStacje.Click += new System.EventHandler(this.btnDodajStacje_Click);
            // 
            // btnUaktualnij
            // 
            this.btnUaktualnij.Location = new System.Drawing.Point(6, 175);
            this.btnUaktualnij.Name = "btnUaktualnij";
            this.btnUaktualnij.Size = new System.Drawing.Size(76, 23);
            this.btnUaktualnij.TabIndex = 15;
            this.btnUaktualnij.Text = "Uaktualnij";
            this.btnUaktualnij.UseVisualStyleBackColor = true;
            this.btnUaktualnij.Click += new System.EventHandler(this.btnUaktualnij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 634);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTrasa);
            this.Controls.Add(this.gmap);
            this.Name = "Form1";
            this.Text = "Stacje benzynowe w Trójmieście";
            this.groupBoxTrasa.ResumeLayout(false);
            this.groupBoxTrasa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button btnAllStations;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBoxTrasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDystans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLonStop;
        private System.Windows.Forms.TextBox textBoxLatStop;
        private System.Windows.Forms.TextBox textBoxLonStart;
        private System.Windows.Forms.TextBox textBoxLatStart;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Button btnClearLatLon;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectnazwa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxStacja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Button btnDodajStacje;
        private System.Windows.Forms.TextBox textBoxCenaD;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxLon;
        private System.Windows.Forms.TextBox textBoxLat;
        private System.Windows.Forms.TextBox textBoxCena95;
        private System.Windows.Forms.Button btnUsunStacje;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.ComboBox comboBoxGasName;
        private System.Windows.Forms.Button btnUaktualnij;
    }
}

