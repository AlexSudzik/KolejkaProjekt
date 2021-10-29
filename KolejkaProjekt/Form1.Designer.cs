
namespace KolejkaProjekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Imie1 = new System.Windows.Forms.TextBox();
            this.NazwaBadania = new System.Windows.Forms.TextBox();
            this.DataBadania = new System.Windows.Forms.TextBox();
            this.DodajButton = new System.Windows.Forms.Button();
            this.DataTeraz = new System.Windows.Forms.TextBox();
            this.GodzinaTeraz = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OsobaPrzedImie = new System.Windows.Forms.TextBox();
            this.OsobaPrzedNazwaBadania = new System.Windows.Forms.TextBox();
            this.OsobaPrzedDataBadania = new System.Windows.Forms.TextBox();
            this.OsobaTerazImie = new System.Windows.Forms.TextBox();
            this.OsobaTerazNazwaBadania = new System.Windows.Forms.TextBox();
            this.OsobaTerazDataBadania = new System.Windows.Forms.TextBox();
            this.OsobaPrzed = new System.Windows.Forms.Label();
            this.OsobaTeraz = new System.Windows.Forms.Label();
            this.OsobaPoImie = new System.Windows.Forms.TextBox();
            this.OsobaPoNazwaBadania = new System.Windows.Forms.TextBox();
            this.OsobaPoDataBadania = new System.Windows.Forms.TextBox();
            this.OsobaPo = new System.Windows.Forms.Label();
            this.LabelDodawanie = new System.Windows.Forms.Label();
            this.UsunButton = new System.Windows.Forms.Button();
            this.CofnijButton = new System.Windows.Forms.Button();
            this.DalejButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Imie1
            // 
            this.Imie1.Location = new System.Drawing.Point(146, 35);
            this.Imie1.Name = "Imie1";
            this.Imie1.Size = new System.Drawing.Size(100, 23);
            this.Imie1.TabIndex = 0;
            this.Imie1.Text = "Imię";
            this.Imie1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NazwaBadania
            // 
            this.NazwaBadania.Location = new System.Drawing.Point(289, 35);
            this.NazwaBadania.Name = "NazwaBadania";
            this.NazwaBadania.Size = new System.Drawing.Size(100, 23);
            this.NazwaBadania.TabIndex = 1;
            this.NazwaBadania.Text = "Nazwa Badania";
            this.NazwaBadania.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DataBadania
            // 
            this.DataBadania.Location = new System.Drawing.Point(443, 35);
            this.DataBadania.Name = "DataBadania";
            this.DataBadania.Size = new System.Drawing.Size(100, 23);
            this.DataBadania.TabIndex = 2;
            this.DataBadania.Text = "Data Badania";
            this.DataBadania.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(588, 35);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(75, 23);
            this.DodajButton.TabIndex = 3;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataTeraz
            // 
            this.DataTeraz.Location = new System.Drawing.Point(887, 35);
            this.DataTeraz.Name = "DataTeraz";
            this.DataTeraz.Size = new System.Drawing.Size(100, 23);
            this.DataTeraz.TabIndex = 4;
            this.DataTeraz.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // GodzinaTeraz
            // 
            this.GodzinaTeraz.Location = new System.Drawing.Point(1007, 35);
            this.GodzinaTeraz.Name = "GodzinaTeraz";
            this.GodzinaTeraz.Size = new System.Drawing.Size(100, 23);
            this.GodzinaTeraz.TabIndex = 5;
            this.GodzinaTeraz.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OsobaPrzedImie
            // 
            this.OsobaPrzedImie.Location = new System.Drawing.Point(146, 192);
            this.OsobaPrzedImie.Name = "OsobaPrzedImie";
            this.OsobaPrzedImie.Size = new System.Drawing.Size(100, 23);
            this.OsobaPrzedImie.TabIndex = 6;
            // 
            // OsobaPrzedNazwaBadania
            // 
            this.OsobaPrzedNazwaBadania.Location = new System.Drawing.Point(289, 192);
            this.OsobaPrzedNazwaBadania.Name = "OsobaPrzedNazwaBadania";
            this.OsobaPrzedNazwaBadania.Size = new System.Drawing.Size(100, 23);
            this.OsobaPrzedNazwaBadania.TabIndex = 7;
            // 
            // OsobaPrzedDataBadania
            // 
            this.OsobaPrzedDataBadania.Location = new System.Drawing.Point(443, 192);
            this.OsobaPrzedDataBadania.Name = "OsobaPrzedDataBadania";
            this.OsobaPrzedDataBadania.Size = new System.Drawing.Size(100, 23);
            this.OsobaPrzedDataBadania.TabIndex = 8;
            // 
            // OsobaTerazImie
            // 
            this.OsobaTerazImie.Location = new System.Drawing.Point(146, 263);
            this.OsobaTerazImie.Name = "OsobaTerazImie";
            this.OsobaTerazImie.Size = new System.Drawing.Size(100, 23);
            this.OsobaTerazImie.TabIndex = 9;
            // 
            // OsobaTerazNazwaBadania
            // 
            this.OsobaTerazNazwaBadania.Location = new System.Drawing.Point(289, 263);
            this.OsobaTerazNazwaBadania.Name = "OsobaTerazNazwaBadania";
            this.OsobaTerazNazwaBadania.Size = new System.Drawing.Size(100, 23);
            this.OsobaTerazNazwaBadania.TabIndex = 10;
            // 
            // OsobaTerazDataBadania
            // 
            this.OsobaTerazDataBadania.Location = new System.Drawing.Point(443, 263);
            this.OsobaTerazDataBadania.Name = "OsobaTerazDataBadania";
            this.OsobaTerazDataBadania.Size = new System.Drawing.Size(100, 23);
            this.OsobaTerazDataBadania.TabIndex = 11;
            // 
            // OsobaPrzed
            // 
            this.OsobaPrzed.AutoSize = true;
            this.OsobaPrzed.Location = new System.Drawing.Point(53, 195);
            this.OsobaPrzed.Name = "OsobaPrzed";
            this.OsobaPrzed.Size = new System.Drawing.Size(73, 15);
            this.OsobaPrzed.TabIndex = 12;
            this.OsobaPrzed.Text = "Osoba Przed";
            // 
            // OsobaTeraz
            // 
            this.OsobaTeraz.AutoSize = true;
            this.OsobaTeraz.Location = new System.Drawing.Point(53, 263);
            this.OsobaTeraz.Name = "OsobaTeraz";
            this.OsobaTeraz.Size = new System.Drawing.Size(70, 15);
            this.OsobaTeraz.TabIndex = 13;
            this.OsobaTeraz.Text = "Osoba Teraz";
            // 
            // OsobaPoImie
            // 
            this.OsobaPoImie.Location = new System.Drawing.Point(146, 333);
            this.OsobaPoImie.Name = "OsobaPoImie";
            this.OsobaPoImie.Size = new System.Drawing.Size(100, 23);
            this.OsobaPoImie.TabIndex = 14;
            // 
            // OsobaPoNazwaBadania
            // 
            this.OsobaPoNazwaBadania.Location = new System.Drawing.Point(289, 333);
            this.OsobaPoNazwaBadania.Name = "OsobaPoNazwaBadania";
            this.OsobaPoNazwaBadania.Size = new System.Drawing.Size(100, 23);
            this.OsobaPoNazwaBadania.TabIndex = 15;
            // 
            // OsobaPoDataBadania
            // 
            this.OsobaPoDataBadania.Location = new System.Drawing.Point(443, 333);
            this.OsobaPoDataBadania.Name = "OsobaPoDataBadania";
            this.OsobaPoDataBadania.Size = new System.Drawing.Size(100, 23);
            this.OsobaPoDataBadania.TabIndex = 16;
            // 
            // OsobaPo
            // 
            this.OsobaPo.AutoSize = true;
            this.OsobaPo.Location = new System.Drawing.Point(53, 333);
            this.OsobaPo.Name = "OsobaPo";
            this.OsobaPo.Size = new System.Drawing.Size(58, 15);
            this.OsobaPo.TabIndex = 17;
            this.OsobaPo.Text = "Osoba Po";
            // 
            // LabelDodawanie
            // 
            this.LabelDodawanie.AutoSize = true;
            this.LabelDodawanie.Location = new System.Drawing.Point(12, 38);
            this.LabelDodawanie.Name = "LabelDodawanie";
            this.LabelDodawanie.Size = new System.Drawing.Size(114, 15);
            this.LabelDodawanie.TabIndex = 18;
            this.LabelDodawanie.Text = "Dodawanie Pacjenta";
            // 
            // UsunButton
            // 
            this.UsunButton.Location = new System.Drawing.Point(604, 263);
            this.UsunButton.Name = "UsunButton";
            this.UsunButton.Size = new System.Drawing.Size(75, 23);
            this.UsunButton.TabIndex = 19;
            this.UsunButton.Text = "Usuń";
            this.UsunButton.UseVisualStyleBackColor = true;
            this.UsunButton.Click += new System.EventHandler(this.UsunButton_Click);
            // 
            // CofnijButton
            // 
            this.CofnijButton.Location = new System.Drawing.Point(604, 192);
            this.CofnijButton.Name = "CofnijButton";
            this.CofnijButton.Size = new System.Drawing.Size(75, 23);
            this.CofnijButton.TabIndex = 20;
            this.CofnijButton.Text = "Cofnij";
            this.CofnijButton.UseVisualStyleBackColor = true;
            this.CofnijButton.Click += new System.EventHandler(this.CofnijButton_Click);
            // 
            // DalejButton
            // 
            this.DalejButton.Location = new System.Drawing.Point(604, 333);
            this.DalejButton.Name = "DalejButton";
            this.DalejButton.Size = new System.Drawing.Size(75, 23);
            this.DalejButton.TabIndex = 21;
            this.DalejButton.Text = "Dalej";
            this.DalejButton.UseVisualStyleBackColor = true;
            this.DalejButton.Click += new System.EventHandler(this.DalejButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 556);
            this.Controls.Add(this.DalejButton);
            this.Controls.Add(this.CofnijButton);
            this.Controls.Add(this.UsunButton);
            this.Controls.Add(this.LabelDodawanie);
            this.Controls.Add(this.OsobaPo);
            this.Controls.Add(this.OsobaPoDataBadania);
            this.Controls.Add(this.OsobaPoNazwaBadania);
            this.Controls.Add(this.OsobaPoImie);
            this.Controls.Add(this.OsobaTeraz);
            this.Controls.Add(this.OsobaPrzed);
            this.Controls.Add(this.OsobaTerazDataBadania);
            this.Controls.Add(this.OsobaTerazNazwaBadania);
            this.Controls.Add(this.OsobaTerazImie);
            this.Controls.Add(this.OsobaPrzedDataBadania);
            this.Controls.Add(this.OsobaPrzedNazwaBadania);
            this.Controls.Add(this.OsobaPrzedImie);
            this.Controls.Add(this.GodzinaTeraz);
            this.Controls.Add(this.DataTeraz);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.DataBadania);
            this.Controls.Add(this.NazwaBadania);
            this.Controls.Add(this.Imie1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Imie1;
        private System.Windows.Forms.TextBox NazwaBadania;
        private System.Windows.Forms.TextBox DataBadania;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.TextBox DataTeraz;
        private System.Windows.Forms.TextBox GodzinaTeraz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox OsobaPrzedImie;
        private System.Windows.Forms.TextBox OsobaPrzedNazwaBadania;
        private System.Windows.Forms.TextBox OsobaPrzedDataBadania;
        private System.Windows.Forms.TextBox OsobaTerazImie;
        private System.Windows.Forms.TextBox OsobaTerazNazwaBadania;
        private System.Windows.Forms.TextBox OsobaTerazDataBadania;
        private System.Windows.Forms.Label OsobaPrzed;
        private System.Windows.Forms.Label OsobaTeraz;
        private System.Windows.Forms.TextBox OsobaPoImie;
        private System.Windows.Forms.TextBox OsobaPoNazwaBadania;
        private System.Windows.Forms.TextBox OsobaPoDataBadania;
        private System.Windows.Forms.Label OsobaPo;
        private System.Windows.Forms.Label LabelDodawanie;
        private System.Windows.Forms.Button UsunButton;
        private System.Windows.Forms.Button CofnijButton;
        private System.Windows.Forms.Button DalejButton;
    }
}

