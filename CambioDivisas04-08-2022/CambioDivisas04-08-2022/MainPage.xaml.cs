using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CambioDivisas04_08_2022
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Pesos_Mexicanos_Clicked(object sender, EventArgs e)
        {
            double x= Convert.ToDouble(Dolares.Text);
            double x1 = (x * 20.33) / 1;
            Resultado.Text = x + " Dólares es = " + x1 + " Pesos Mexicanos";
        }
        private void Euros_Clicked(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(Dolares.Text);
            double x1 = (x * 0.98) / 1;
            Resultado.Text = x + " Dólares es = " + x1 + " Euros";
        }

        private void Libras_Clicked(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(Dolares.Text);
            double x1 = (x * 0.82) / 1;
            Resultado.Text = x + " Dólares es = " + x1 + " Libras Esterlinas";
        }

        private void Yen_Clicked(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(Dolares.Text);
            double x1 = (x * 133.14) / 1;
            Resultado.Text = x + " Dólares es = " + x1 + " Yen Japonés";
        }

        private void Soles_Clicked(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(Dolares.Text);
            double x1 = (x * 3.90) / 1;
            Resultado.Text = x + " Dólares es = " + x1 + " Sol Peruano";
        }    
    }
}
