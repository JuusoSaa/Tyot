using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Koe_Juuso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class arvot
        {

        }

        private void btn_Laske_Click(object sender, EventArgs e)
        {
            try
            {
                double pizza1 = 0, pizza2 = 0, pizza3 = 0, pizza4 = 0, pizza5 = 0, pizza6 = 0, pizza7 = 0, pizza8 = 0, pizza9 = 0, pizza10 = 0, lisa1 = 0, lisa2 = 0 , lisa3 = 0, lisa4 = 0, juoma1 = 0, juoma2 = 0;
                double Maara = 0;
                double yhteishinta;


                 //hintojen koodaus
                 if (chkBox_Pizza_1.Checked) { pizza1 = 10.20; Maara++; }
                 if (chkBox_Pizza_2.Checked) { pizza2 = 9.80; Maara++; }
                 if (chkBox_Pizza_3.Checked) { pizza3 = 10.0; Maara++; }
                 if (chkBox_Pizza_4.Checked) { pizza4 = 8.80; Maara++; }
                 if (chkBox_Pizza_5.Checked) { pizza5 = 12.40; Maara++; }
                 if (chkBox_Pizza_6.Checked) { pizza6 = 9.80; Maara++; }
                 if (chkBox_Pizza_7.Checked) { pizza7 = 13.30; Maara++; }
                 if (chkBox_Pizza_8.Checked) { pizza8 = 10.20; Maara++; }
                 if (chkBox_Pizza_9.Checked) { pizza9 = 10.0; Maara++; }
                 if (chkBox_Pizza_10.Checked) { pizza10 = 9.90; Maara++; }

                 if (chkBox_Ltäyte_1.Checked) { lisa1 = 1.0; }
                 if (chkBox_Ltäyte_2.Checked) { lisa2 = 1.0; }
                 if (chkBox_Ltäyte_3.Checked) { lisa3 = 1.0; }
                 if (chkBox_Ltäyte_4.Checked) { lisa4 = 1.0; }

                if (chkBox_Juoma_1.Checked) { juoma1 = 2.5; }
                if (chkBox_Juoma_2.Checked) { juoma2 = 4.0; }

                  //Tässä annan arvon näille määrille mitä tulee tarvitsemaan
                double pizzaMaara1 = 0, pizzaMaara2 = 0, pizzaMaara3 = 0 , pizzaMaara4 = 0, pizzaMaara5 = 0, pizzaMaara6 = 0, pizzaMaara7 = 0, pizzaMaara8 = 0, pizzaMaara9 = 0, pizzaMaara10 = 0;
                double juomaMaara1 = 0, juomaMaara2 = 0;
                double lisaT1 = 0, lisaT2 = 0, lisaT3 = 0, lisaT4 = 0;

                  //Tässä katsotaan montako lukua on textboxissa jotta tiedetään montako asiakas haluaa
        
                if (!double.TryParse(txtBox_Pizza1.Text, out pizzaMaara1))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Pizza2.Text, out pizzaMaara2))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Pizza3.Text, out pizzaMaara3))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Pizza4.Text, out pizzaMaara4))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Pizza5.Text, out pizzaMaara5))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Pizza6.Text, out pizzaMaara6))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Pizza7.Text, out pizzaMaara7))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Pizza8.Text, out pizzaMaara8))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Pizza9.Text, out pizzaMaara9))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Pizza10.Text, out pizzaMaara10))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Juoma1.Text, out juomaMaara1))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Juoma2.Text, out juomaMaara2))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Lisa1.Text, out lisaT1))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Lisa2.Text, out lisaT2))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Lisa3.Text, out lisaT3))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                if (!double.TryParse(txtBox_Lisa4.Text, out lisaT4))
                {
                    MessageBox.Show("Syötä oikea luku");
                    return;
                }
                bool pizzapassi = chkBox_Pizzapassi.Checked;

                // Yritin laskea alennuksen
                double alennus = 0;
                if (pizzapassi && (Maara % 6 == 0))
                {
                    alennus = (pizzaMaara1 + pizzaMaara2 + pizzaMaara3 + pizzaMaara4 + pizzaMaara5 + pizzaMaara6 + pizzaMaara7 + pizzaMaara8 + pizzaMaara9 + pizzaMaara10) / 2;
                }
                //Tässä sitten kerrotaan kaikki tuotteet ja lasketaan ne yhteen
                yhteishinta = ((pizza1 * pizzaMaara1) + (pizza2 * pizzaMaara2) + (pizza3 * pizzaMaara3) + (pizza4 * pizzaMaara4) + (pizza5 * pizzaMaara5) +
                        (pizza6 * pizzaMaara6) + (pizza7 * pizzaMaara7) + (pizza8 * pizzaMaara8) + (pizza9 * pizzaMaara9) + (pizza10 * pizzaMaara10) - alennus) +
                        (lisa1 * lisaT1) + (lisa2 * lisaT2) + (lisa3 * lisaT3) + (lisa4 * lisaT4) + (juoma1 * juomaMaara1) + (juoma2 * juomaMaara2);
                MessageBox.Show("Otit lisätäytteitä:" + Environment.NewLine + "Rukola:" + lisaT1 + Environment.NewLine + "Sinihomejuusto:" + lisaT2 + Environment.NewLine + "Sipuli:" + lisaT3 + Environment.NewLine + "Lisä juusto" + lisaT4 + Environment.NewLine + "Otit juomia" + Environment.NewLine + "0,5L:" + juomaMaara1 + " " + "Ja 1,5L:" + juomaMaara2 + Environment.NewLine + "Pitsoja otit:" + Environment.NewLine + "Kuatro:" + pizzaMaara1 + Environment.NewLine + "Special Kebab:" + pizzaMaara2 + Environment.NewLine + "Jalapeno extra" + pizzaMaara3 + Environment.NewLine + "Chili head" + pizzaMaara4 + Environment.NewLine + "American:" + pizzaMaara5 + Environment.NewLine + " Tupla pepperoni:" + pizzaMaara6 + Environment.NewLine + "Pepperoni" + pizzaMaara7 + Environment.NewLine + "Halloum kinkku" + pizzaMaara8 + Environment.NewLine + "Vuohenjuusto Special" + pizzaMaara9 + Environment.NewLine + "Talon erikoisuus" + pizzaMaara10 + Environment.NewLine + "Yhteishinnaksi näille tuli:" + " " + yhteishinta + "€"); //Tässäpä tulos
            }// Vastauksen halusin listana joten tuli aika pitkä
            catch (Exception ex)
            { MessageBox.Show("Jokin meni vikaan"); }


        }

        private void btn_Nollaa_Click(object sender, EventArgs e)
        {
            // Napista kun painaa niin kaikki textboxit nollaantuu
            txtBox_Pizza1.Clear();
            txtBox_Pizza2.Clear();
            txtBox_Pizza3.Clear();
            txtBox_Pizza4.Clear();
            txtBox_Pizza5.Clear();
            txtBox_Pizza6.Clear();
            txtBox_Pizza7.Clear();
            txtBox_Pizza8.Clear();
            txtBox_Pizza9.Clear();
            txtBox_Pizza10.Clear();
            txtBox_Lisa1.Clear();
            txtBox_Lisa2.Clear();
            txtBox_Lisa3.Clear();
            txtBox_Lisa4.Clear();
            txtBox_Juoma1.Clear();
            txtBox_Juoma2.Clear();
        }
    }
}
