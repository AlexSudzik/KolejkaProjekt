using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolejkaProjekt
{
    public partial class Form1 : Form
    {
        private List<string> imiona = new List<string>(10);
        private List<string> nazwyBadan = new List<string>(10);
        private List<string> datyBadan = new List<string>(10);

        private int imiex = 1;
        private int nazwax = 1;
        private int datax = 1;


        public Form1()
        {

            InitializeComponent();
            DataTeraz.Text = DateTime.Now.Date.ToShortDateString();
            GodzinaTeraz.Text = DateTime.Now.ToString("hh:mm:ss");

           

            imiona.Add("Jan Kowalski");
            imiona.Add("Adam Nowak");
            imiona.Add("Stefan Cebula");
            imiona.Add("Hubert Bubert");
            imiona.Add("Alojizy Cegla");
            imiona.Add("Juliusz Cezar");
            imiona.Add("Oliwier Gnebliciel");
            imiona.Add("Tyler Ferrar");
            imiona.Add("Wladyslaw Maka");
            imiona.Add("Leon Moneta");
            OsobaPrzedImie.Text = imiona[1];
            OsobaTerazImie.Text = imiona[2];
            OsobaPoImie.Text = imiona[3];

            nazwyBadan.Add("Morfologia");
            nazwyBadan.Add("Glukoza");
            nazwyBadan.Add("Badanie tarczycy");
            nazwyBadan.Add("Badanie kreatyniny.");
            nazwyBadan.Add("Lipidogram");
            nazwyBadan.Add("Kolonoskopia");
            nazwyBadan.Add("Eutanazja");
            nazwyBadan.Add("Pobieranie krwi");
            nazwyBadan.Add("Szczepienie");
            nazwyBadan.Add("Chemioterapia");
            OsobaPrzedNazwaBadania.Text = nazwyBadan[1];
            OsobaTerazNazwaBadania.Text = nazwyBadan[2];
            OsobaPoNazwaBadania.Text = nazwyBadan[3];

            datyBadan.Add("21.10.21");
            datyBadan.Add("22.10.21");
            datyBadan.Add("24.10.21");
            datyBadan.Add("30.10.21");
            datyBadan.Add("7.11.21");
            datyBadan.Add("9.11.21");
            datyBadan.Add("15.11.21");
            datyBadan.Add("16.11.21");
            datyBadan.Add("20.11.21");
            datyBadan.Add("25.11.21");

            OsobaPrzedDataBadania.Text = datyBadan[1];
            OsobaTerazDataBadania.Text = datyBadan[2];
            OsobaPoDataBadania.Text = datyBadan[3];

           

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GodzinaTeraz.Text = DateTime.Now.ToString("hh:mm:ss");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DalejButton_Click(object sender, EventArgs e)
        {
            imiex += 1;
            nazwax += 1;
            datax += 1;

            OsobaPrzedImie.Text = imiona[imiex];
            imiex += 1;
            OsobaTerazImie.Text = imiona[imiex];
            imiex += 1;
            OsobaPoImie.Text = imiona[imiex];



            OsobaPrzedNazwaBadania.Text = nazwyBadan[nazwax];
            nazwax += 1;
            OsobaTerazNazwaBadania.Text = nazwyBadan[nazwax];
            nazwax += 1;
            OsobaPoNazwaBadania.Text = nazwyBadan[nazwax];

           // OsobaPrzedDataBadania = datyBadan[datax];

           
        }
    }
}
