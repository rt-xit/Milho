using System;
using Microsoft.Maui.Controls;

namespace Milho
{
    public partial class MainPage : ContentPage
    {
        private int _pontuacao;
        private int _perguntaAtualIndex;
        private readonly Pergunta[] _perguntas = new Pergunta[]
        {
            new Pergunta("Qual é a capital do Brasil?",
                new[] { "Brasília", "São Paulo", "Rio de Janeiro", "Salvador" },
                'A'),
            new Pergunta("Quem escreveu 'Dom Casmurro'?",
                new[] { "Machado de Assis", "José de Alencar", "Guimarães Rosa", "Carlos Drummond de Andrade" },
                'A'),
            new Pergunta("Qual é o maior planeta do Sistema Solar?",
                new[] { "Terra", "Júpiter", "Marte", "Saturno" },
                'B')
        };

        public MainPage()
        {
            InitializeComponent();
            _pontuacao = 0;
            _perguntaAtualIndex = 0;
            MostrarPergunta();
        }

        private void MostrarPergunta()
        {
            if (_perguntaAtualIndex >= _perguntas.Length)
            {
                PerguntaLabel.Text = "Jogo Finalizado!";
                RespostaA.IsVisible = RespostaB.IsVisible = RespostaC.IsVisible = RespostaD.IsVisible = false;
                return;
            }

            var pergunta = _perguntas[_perguntaAtualIndex];
            PerguntaLabel.Text = pergunta.Texto;
            RespostaA.Content = pergunta.Respostas[0];
            RespostaB.Content = pergunta.Respostas[1];
            RespostaC.Content = pergunta.Respostas[2];
            RespostaD.Content = pergunta.Respostas[3];
        }


        private void OnEnviarRespostaClicked(object sender, EventArgs e)
        {
            var respostaSelecionada = GetRespostaSelecionada();
            var perguntaAtual = _perguntas[_perguntaAtualIndex];
            if (respostaSelecionada == perguntaAtual.Correta)
            {
                _pontuacao++;
                DisplayAlert("Resposta Correta!", "Parabéns, você acertou!", "OK");
            }
            else
            {
                DisplayAlert("Resposta Incorreta", $"A resposta correta era {perguntaAtual.Correta}.", "OK");
            }

            _perguntaAtualIndex++;
            MostrarPergunta();
            PontuacaoLabel.Text = $"Pontuação: {_pontuacao}";
        }

        private char GetRespostaSelecionada()
        {
            if (RespostaA.IsChecked) return 'A';
            if (RespostaB.IsChecked) return 'B';
            if (RespostaC.IsChecked) return 'C';
            if (RespostaD.IsChecked) return 'D';
            return ' ';
        }

        private class Pergunta
        {
            public string Texto { get; }
            public string[] Respostas { get; }
            public char Correta { get; }

            public Pergunta(string texto, string[] respostas, char correta)
            {
                Texto = texto;
                Respostas = respostas;
                Correta = correta;
            }
        }
    }
}


