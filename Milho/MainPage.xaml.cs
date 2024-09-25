﻿namespace Milho
{
    public partial class MainPage : ContentPage
    {
        Gerenciador gerenciador;

        public MainPage()
        {
            InitializeComponent();
            gerenciador = new Gerenciador(labelpergunta, Button1, Button2, Button3, Button4, Button5);
            gerenciador.ProximaQuestao();
        }   

        void OnButtonResposta01ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(1); // Correção aqui
        }
        void OnButtonResposta02ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(2); // Correção aqui
        }
        void OnButtonResposta03ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(3); // Correção aqui
        }
        void OnButtonResposta04ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(4); // Correção aqui
        }
        void OnButtonResposta05ButtonClicked(object sender, EventArgs args)
        {
            gerenciador.VerificaCorreta(5); // Correção aqui
        }

         private void Convidados(object sender, EventArgs e)
        {
           Application.Current.MainPage = new Convidados();
        }
    }
}