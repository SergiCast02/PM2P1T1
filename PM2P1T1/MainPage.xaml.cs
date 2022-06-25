using PM2P1T1.Models;
using PM2P1T1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2P1T1
{
    public partial class MainPage : ContentPage
    {
        Operaciones op = new Operaciones();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            try
            {
                var resultado = op.getSuma(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text));
                await Navigation.PushAsync(new Resultados(resultado));
            }
            catch (Exception error){ await DisplayAlert("Aviso", "Llene todos los campos", "OK"); }            
        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            try
            {
                var resultado = op.getResta(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text));
                await Navigation.PushAsync(new Resultados(resultado));
            }
            catch (Exception error) { await DisplayAlert("Aviso", "Llene todos los campos", "OK"); }
            
        }

        private async void btndivision_Clicked(object sender, EventArgs e)
        {
            try
            {
                var resultado = op.getDivision(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text));
                await Navigation.PushAsync(new Resultados(resultado));
            }
            catch (Exception error) { await DisplayAlert("Aviso", "Llene todos los campos", "OK"); }
        }

        private async void btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            try
            {
                var resultado = op.getMultiplicacion(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text));
                await Navigation.PushAsync(new Resultados(resultado));
            }
            catch (Exception error) { await DisplayAlert("Aviso", "Llene todos los campos", "OK"); }
        }
    }
}
