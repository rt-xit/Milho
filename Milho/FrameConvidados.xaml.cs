using Microsoft.Maui.Controls;

namespace Milho
{
    public partial class FrameConvidados : ContentPage
    {
        public FrameConvidados()
        {
            InitializeComponent();
        }

        // Evento Clicked para o botão Voltar
        private void VoltarClicked(object sender, EventArgs e)
        {
            // Lógica para voltar à página anterior
            Navigation.PopAsync();
        }
    }
}
