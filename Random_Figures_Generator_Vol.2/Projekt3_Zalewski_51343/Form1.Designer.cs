namespace Projekt3_Zalewski_51343
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
            this.components = new System.ComponentModel.Container();
            this.pztbPromieńBryły = new System.Windows.Forms.TrackBar();
            this.pzlabel1 = new System.Windows.Forms.Label();
            this.pzlabel2 = new System.Windows.Forms.Label();
            this.pztbWysokośćBryły = new System.Windows.Forms.TrackBar();
            this.pzlabel3 = new System.Windows.Forms.Label();
            this.pznumStopieńWielokąta = new System.Windows.Forms.NumericUpDown();
            this.pzlabel4 = new System.Windows.Forms.Label();
            this.pztbKątNachyleniaBryły = new System.Windows.Forms.TrackBar();
            this.pzbtnDodajNowąBryłe = new System.Windows.Forms.Button();
            this.pzbtnKierunekObrotuPrawo = new System.Windows.Forms.Button();
            this.pzbtnKierunekObrotuLewo = new System.Windows.Forms.Button();
            this.pzbtnNoweAtrybutyGraficzne = new System.Windows.Forms.Button();
            this.pzbtnWylosujNowePołożenie = new System.Windows.Forms.Button();
            this.pzbtnUsuńPierwsząBryłę = new System.Windows.Forms.Button();
            this.pzbtnUsuńOstatnioDodanąBryłę = new System.Windows.Forms.Button();
            this.pzbtnUsuńWybranąBryłę = new System.Windows.Forms.Button();
            this.pznumBryłaDoUsunięcia = new System.Windows.Forms.NumericUpDown();
            this.pzpbPowierzchniaGraficzna = new System.Windows.Forms.PictureBox();
            this.pztimerObrotów = new System.Windows.Forms.Timer(this.components);
            this.pzcmbListaBrył = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.kmmlblKątPochylenia = new System.Windows.Forms.Label();
            this.kmlblPromieńBryły = new System.Windows.Forms.Label();
            this.kmlblWysokośćBryły = new System.Windows.Forms.Label();
            this.pzlabel6 = new System.Windows.Forms.Label();
            this.pztextBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pztbPromieńBryły)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pztbWysokośćBryły)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pznumStopieńWielokąta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pztbKątNachyleniaBryły)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pznumBryłaDoUsunięcia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pzpbPowierzchniaGraficzna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pztbPromieńBryły
            // 
            this.pztbPromieńBryły.Location = new System.Drawing.Point(12, 59);
            this.pztbPromieńBryły.Maximum = 200;
            this.pztbPromieńBryły.Minimum = 20;
            this.pztbPromieńBryły.Name = "pztbPromieńBryły";
            this.pztbPromieńBryły.Size = new System.Drawing.Size(191, 45);
            this.pztbPromieńBryły.TabIndex = 0;
            this.pztbPromieńBryły.TickFrequency = 10;
            this.pztbPromieńBryły.Value = 110;
            // 
            // pzlabel1
            // 
            this.pzlabel1.AutoSize = true;
            this.pzlabel1.Location = new System.Drawing.Point(12, 40);
            this.pzlabel1.Name = "pzlabel1";
            this.pzlabel1.Size = new System.Drawing.Size(103, 13);
            this.pzlabel1.TabIndex = 2;
            this.pzlabel1.Text = "Ustaw promień bryły";
            // 
            // pzlabel2
            // 
            this.pzlabel2.AutoSize = true;
            this.pzlabel2.Location = new System.Drawing.Point(15, 90);
            this.pzlabel2.Name = "pzlabel2";
            this.pzlabel2.Size = new System.Drawing.Size(113, 13);
            this.pzlabel2.TabIndex = 3;
            this.pzlabel2.Text = "Ustaw wysokość bryły";
            // 
            // pztbWysokośćBryły
            // 
            this.pztbWysokośćBryły.Location = new System.Drawing.Point(12, 110);
            this.pztbWysokośćBryły.Maximum = 200;
            this.pztbWysokośćBryły.Minimum = 20;
            this.pztbWysokośćBryły.Name = "pztbWysokośćBryły";
            this.pztbWysokośćBryły.Size = new System.Drawing.Size(191, 45);
            this.pztbWysokośćBryły.TabIndex = 4;
            this.pztbWysokośćBryły.TickFrequency = 10;
            this.pztbWysokośćBryły.Value = 110;
            // 
            // pzlabel3
            // 
            this.pzlabel3.AutoSize = true;
            this.pzlabel3.Location = new System.Drawing.Point(13, 148);
            this.pzlabel3.Name = "pzlabel3";
            this.pzlabel3.Size = new System.Drawing.Size(91, 13);
            this.pzlabel3.TabIndex = 5;
            this.pzlabel3.Text = "Stopień wielokąta";
            // 
            // pznumStopieńWielokąta
            // 
            this.pznumStopieńWielokąta.Location = new System.Drawing.Point(18, 165);
            this.pznumStopieńWielokąta.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.pznumStopieńWielokąta.Name = "pznumStopieńWielokąta";
            this.pznumStopieńWielokąta.ReadOnly = true;
            this.pznumStopieńWielokąta.Size = new System.Drawing.Size(120, 20);
            this.pznumStopieńWielokąta.TabIndex = 6;
            this.pznumStopieńWielokąta.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // pzlabel4
            // 
            this.pzlabel4.AutoSize = true;
            this.pzlabel4.Location = new System.Drawing.Point(15, 192);
            this.pzlabel4.Name = "pzlabel4";
            this.pzlabel4.Size = new System.Drawing.Size(174, 13);
            this.pzlabel4.TabIndex = 7;
            this.pzlabel4.Text = "Kąt nachylenia bryły geometrycznej";
            // 
            // pztbKątNachyleniaBryły
            // 
            this.pztbKątNachyleniaBryły.Location = new System.Drawing.Point(18, 209);
            this.pztbKątNachyleniaBryły.Maximum = 150;
            this.pztbKątNachyleniaBryły.Minimum = 30;
            this.pztbKątNachyleniaBryły.Name = "pztbKątNachyleniaBryły";
            this.pztbKątNachyleniaBryły.Size = new System.Drawing.Size(185, 45);
            this.pztbKątNachyleniaBryły.TabIndex = 8;
            this.pztbKątNachyleniaBryły.TickFrequency = 30;
            this.pztbKątNachyleniaBryły.Value = 90;
            // 
            // pzbtnDodajNowąBryłe
            // 
            this.pzbtnDodajNowąBryłe.Location = new System.Drawing.Point(18, 260);
            this.pzbtnDodajNowąBryłe.Name = "pzbtnDodajNowąBryłe";
            this.pzbtnDodajNowąBryłe.Size = new System.Drawing.Size(171, 23);
            this.pzbtnDodajNowąBryłe.TabIndex = 9;
            this.pzbtnDodajNowąBryłe.Text = "Dodaj nową bryłę";
            this.pzbtnDodajNowąBryłe.UseVisualStyleBackColor = true;
            this.pzbtnDodajNowąBryłe.Click += new System.EventHandler(this.pzbtnDodajNowąBryłe_Click);
            // 
            // pzbtnKierunekObrotuPrawo
            // 
            this.pzbtnKierunekObrotuPrawo.Location = new System.Drawing.Point(18, 290);
            this.pzbtnKierunekObrotuPrawo.Name = "pzbtnKierunekObrotuPrawo";
            this.pzbtnKierunekObrotuPrawo.Size = new System.Drawing.Size(171, 37);
            this.pzbtnKierunekObrotuPrawo.TabIndex = 10;
            this.pzbtnKierunekObrotuPrawo.Text = "Kierunek obrotu w prawo";
            this.pzbtnKierunekObrotuPrawo.UseVisualStyleBackColor = true;
            this.pzbtnKierunekObrotuPrawo.Click += new System.EventHandler(this.pzbtnKierunekObrotuPrawo_Click);
            // 
            // pzbtnKierunekObrotuLewo
            // 
            this.pzbtnKierunekObrotuLewo.Location = new System.Drawing.Point(18, 333);
            this.pzbtnKierunekObrotuLewo.Name = "pzbtnKierunekObrotuLewo";
            this.pzbtnKierunekObrotuLewo.Size = new System.Drawing.Size(171, 34);
            this.pzbtnKierunekObrotuLewo.TabIndex = 11;
            this.pzbtnKierunekObrotuLewo.Text = "Kierunek obrotu w lewo";
            this.pzbtnKierunekObrotuLewo.UseVisualStyleBackColor = true;
            this.pzbtnKierunekObrotuLewo.Click += new System.EventHandler(this.pzbtnKierunekObrotuLewo_Click);
            // 
            // pzbtnNoweAtrybutyGraficzne
            // 
            this.pzbtnNoweAtrybutyGraficzne.Location = new System.Drawing.Point(18, 374);
            this.pzbtnNoweAtrybutyGraficzne.Name = "pzbtnNoweAtrybutyGraficzne";
            this.pzbtnNoweAtrybutyGraficzne.Size = new System.Drawing.Size(171, 38);
            this.pzbtnNoweAtrybutyGraficzne.TabIndex = 12;
            this.pzbtnNoweAtrybutyGraficzne.Text = "Ustaw nowe atrybuty graficzne";
            this.pzbtnNoweAtrybutyGraficzne.UseVisualStyleBackColor = true;
            this.pzbtnNoweAtrybutyGraficzne.Click += new System.EventHandler(this.pzbtnNoweAtrybutyGraficzne_Click);
            // 
            // pzbtnWylosujNowePołożenie
            // 
            this.pzbtnWylosujNowePołożenie.Location = new System.Drawing.Point(18, 419);
            this.pzbtnWylosujNowePołożenie.Name = "pzbtnWylosujNowePołożenie";
            this.pzbtnWylosujNowePołożenie.Size = new System.Drawing.Size(171, 39);
            this.pzbtnWylosujNowePołożenie.TabIndex = 13;
            this.pzbtnWylosujNowePołożenie.Text = "Wylosuj nowe położenie";
            this.pzbtnWylosujNowePołożenie.UseVisualStyleBackColor = true;
            this.pzbtnWylosujNowePołożenie.Click += new System.EventHandler(this.pzbtnWylosujNowePołożenie_Click);
            // 
            // pzbtnUsuńPierwsząBryłę
            // 
            this.pzbtnUsuńPierwsząBryłę.Location = new System.Drawing.Point(18, 466);
            this.pzbtnUsuńPierwsząBryłę.Name = "pzbtnUsuńPierwsząBryłę";
            this.pzbtnUsuńPierwsząBryłę.Size = new System.Drawing.Size(171, 40);
            this.pzbtnUsuńPierwsząBryłę.TabIndex = 14;
            this.pzbtnUsuńPierwsząBryłę.Text = "Usuń pierwszą dodaną bryłę";
            this.pzbtnUsuńPierwsząBryłę.UseVisualStyleBackColor = true;
            this.pzbtnUsuńPierwsząBryłę.Click += new System.EventHandler(this.pzbtnUsuńPierwsząBryłę_Click);
            // 
            // pzbtnUsuńOstatnioDodanąBryłę
            // 
            this.pzbtnUsuńOstatnioDodanąBryłę.Location = new System.Drawing.Point(329, 510);
            this.pzbtnUsuńOstatnioDodanąBryłę.Name = "pzbtnUsuńOstatnioDodanąBryłę";
            this.pzbtnUsuńOstatnioDodanąBryłę.Size = new System.Drawing.Size(97, 40);
            this.pzbtnUsuńOstatnioDodanąBryłę.TabIndex = 15;
            this.pzbtnUsuńOstatnioDodanąBryłę.Text = "Usuń ostatnio dodaną bryłę";
            this.pzbtnUsuńOstatnioDodanąBryłę.UseVisualStyleBackColor = true;
            this.pzbtnUsuńOstatnioDodanąBryłę.Click += new System.EventHandler(this.pzbtnUsuńOstatnioDodanąBryłę_Click);
            // 
            // pzbtnUsuńWybranąBryłę
            // 
            this.pzbtnUsuńWybranąBryłę.Location = new System.Drawing.Point(18, 512);
            this.pzbtnUsuńWybranąBryłę.Name = "pzbtnUsuńWybranąBryłę";
            this.pzbtnUsuńWybranąBryłę.Size = new System.Drawing.Size(171, 40);
            this.pzbtnUsuńWybranąBryłę.TabIndex = 16;
            this.pzbtnUsuńWybranąBryłę.Text = "Usuń wybraną bryłę";
            this.pzbtnUsuńWybranąBryłę.UseVisualStyleBackColor = true;
            this.pzbtnUsuńWybranąBryłę.Click += new System.EventHandler(this.pzbtnUsuńWybranąBryłę_Click);
            // 
            // pznumBryłaDoUsunięcia
            // 
            this.pznumBryłaDoUsunięcia.Location = new System.Drawing.Point(444, 530);
            this.pznumBryłaDoUsunięcia.Name = "pznumBryłaDoUsunięcia";
            this.pznumBryłaDoUsunięcia.Size = new System.Drawing.Size(45, 20);
            this.pznumBryłaDoUsunięcia.TabIndex = 17;
            // 
            // pzpbPowierzchniaGraficzna
            // 
            this.pzpbPowierzchniaGraficzna.BackColor = System.Drawing.SystemColors.Info;
            this.pzpbPowierzchniaGraficzna.Location = new System.Drawing.Point(209, 60);
            this.pzpbPowierzchniaGraficzna.Name = "pzpbPowierzchniaGraficzna";
            this.pzpbPowierzchniaGraficzna.Size = new System.Drawing.Size(828, 398);
            this.pzpbPowierzchniaGraficzna.TabIndex = 26;
            this.pzpbPowierzchniaGraficzna.TabStop = false;
            // 
            // pztimerObrotów
            // 
            this.pztimerObrotów.Enabled = true;
            this.pztimerObrotów.Tick += new System.EventHandler(this.pztimerObrotów_Tick);
            // 
            // pzcmbListaBrył
            // 
            this.pzcmbListaBrył.FormattingEnabled = true;
            this.pzcmbListaBrył.Items.AddRange(new object[] {
            "Stożek",
            "Walec",
            "Kula",
            "Ostrosłup",
            "Graniastosłup"});
            this.pzcmbListaBrył.Location = new System.Drawing.Point(16, 12);
            this.pzcmbListaBrył.Name = "pzcmbListaBrył";
            this.pzcmbListaBrył.Size = new System.Drawing.Size(187, 21);
            this.pzcmbListaBrył.TabIndex = 27;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // kmmlblKątPochylenia
            // 
            this.kmmlblKątPochylenia.AutoSize = true;
            this.kmmlblKątPochylenia.Location = new System.Drawing.Point(18, 241);
            this.kmmlblKątPochylenia.Name = "kmmlblKątPochylenia";
            this.kmmlblKątPochylenia.Size = new System.Drawing.Size(0, 13);
            this.kmmlblKątPochylenia.TabIndex = 28;
            // 
            // kmlblPromieńBryły
            // 
            this.kmlblPromieńBryły.AutoSize = true;
            this.kmlblPromieńBryły.Location = new System.Drawing.Point(122, 60);
            this.kmlblPromieńBryły.Name = "kmlblPromieńBryły";
            this.kmlblPromieńBryły.Size = new System.Drawing.Size(0, 13);
            this.kmlblPromieńBryły.TabIndex = 29;
            // 
            // kmlblWysokośćBryły
            // 
            this.kmlblWysokośćBryły.AutoSize = true;
            this.kmlblWysokośćBryły.Location = new System.Drawing.Point(123, 107);
            this.kmlblWysokośćBryły.Name = "kmlblWysokośćBryły";
            this.kmlblWysokośćBryły.Size = new System.Drawing.Size(0, 13);
            this.kmlblWysokośćBryły.TabIndex = 30;
            // 
            // pzlabel6
            // 
            this.pzlabel6.AutoSize = true;
            this.pzlabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pzlabel6.Location = new System.Drawing.Point(763, 473);
            this.pzlabel6.Name = "pzlabel6";
            this.pzlabel6.Size = new System.Drawing.Size(164, 20);
            this.pzlabel6.TabIndex = 31;
            this.pzlabel6.Text = "Samoocena projektu: ";
            // 
            // pztextBox1
            // 
            this.pztextBox1.Location = new System.Drawing.Point(933, 473);
            this.pztextBox1.Name = "pztextBox1";
            this.pztextBox1.Size = new System.Drawing.Size(100, 20);
            this.pztextBox1.TabIndex = 32;
            this.pztextBox1.Text = "4,5";
            this.pztextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pztextBox1.TextChanged += new System.EventHandler(this.pztextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 575);
            this.Controls.Add(this.pztextBox1);
            this.Controls.Add(this.pzlabel6);
            this.Controls.Add(this.kmlblWysokośćBryły);
            this.Controls.Add(this.kmlblPromieńBryły);
            this.Controls.Add(this.kmmlblKątPochylenia);
            this.Controls.Add(this.pzcmbListaBrył);
            this.Controls.Add(this.pzpbPowierzchniaGraficzna);
            this.Controls.Add(this.pznumBryłaDoUsunięcia);
            this.Controls.Add(this.pzbtnUsuńWybranąBryłę);
            this.Controls.Add(this.pzbtnUsuńOstatnioDodanąBryłę);
            this.Controls.Add(this.pzbtnUsuńPierwsząBryłę);
            this.Controls.Add(this.pzbtnWylosujNowePołożenie);
            this.Controls.Add(this.pzbtnNoweAtrybutyGraficzne);
            this.Controls.Add(this.pzbtnKierunekObrotuLewo);
            this.Controls.Add(this.pzbtnKierunekObrotuPrawo);
            this.Controls.Add(this.pzbtnDodajNowąBryłe);
            this.Controls.Add(this.pztbKątNachyleniaBryły);
            this.Controls.Add(this.pzlabel4);
            this.Controls.Add(this.pznumStopieńWielokąta);
            this.Controls.Add(this.pzlabel3);
            this.Controls.Add(this.pztbWysokośćBryły);
            this.Controls.Add(this.pzlabel2);
            this.Controls.Add(this.pzlabel1);
            this.Controls.Add(this.pztbPromieńBryły);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pztbPromieńBryły)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pztbWysokośćBryły)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pznumStopieńWielokąta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pztbKątNachyleniaBryły)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pznumBryłaDoUsunięcia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pzpbPowierzchniaGraficzna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar pztbPromieńBryły;
        private System.Windows.Forms.Label pzlabel1;
        private System.Windows.Forms.Label pzlabel2;
        private System.Windows.Forms.TrackBar pztbWysokośćBryły;
        private System.Windows.Forms.Label pzlabel3;
        private System.Windows.Forms.NumericUpDown pznumStopieńWielokąta;
        private System.Windows.Forms.Label pzlabel4;
        private System.Windows.Forms.TrackBar pztbKątNachyleniaBryły;
        private System.Windows.Forms.Button pzbtnDodajNowąBryłe;
        private System.Windows.Forms.Button pzbtnKierunekObrotuPrawo;
        private System.Windows.Forms.Button pzbtnKierunekObrotuLewo;
        private System.Windows.Forms.Button pzbtnNoweAtrybutyGraficzne;
        private System.Windows.Forms.Button pzbtnWylosujNowePołożenie;
        private System.Windows.Forms.Button pzbtnUsuńPierwsząBryłę;
        private System.Windows.Forms.Button pzbtnUsuńOstatnioDodanąBryłę;
        private System.Windows.Forms.Button pzbtnUsuńWybranąBryłę;
        private System.Windows.Forms.NumericUpDown pznumBryłaDoUsunięcia;
        private System.Windows.Forms.PictureBox pzpbPowierzchniaGraficzna;
        private System.Windows.Forms.ComboBox pzcmbListaBrył;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label kmmlblKątPochylenia;
        public System.Windows.Forms.Timer pztimerObrotów;
        private System.Windows.Forms.Label kmlblWysokośćBryły;
        private System.Windows.Forms.Label kmlblPromieńBryły;
        private System.Windows.Forms.Label pzlabel6;
        private System.Windows.Forms.TextBox pztextBox1;
    }
}

