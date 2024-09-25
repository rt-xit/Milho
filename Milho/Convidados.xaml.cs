using System;
using Microsoft.Maui.Controls;

namespace Milho
{
    public partial class Convidados : ContentPage
    {
        public Convidados()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, EventArgs e)
        {
           Application.Current.MainPage = new MainPage();
        }
    }
}
