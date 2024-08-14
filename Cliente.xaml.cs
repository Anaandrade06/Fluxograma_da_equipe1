using Microsoft.Maui.Controls;

namespace Fluxograma_da_equipe1
{
    public partial class ClientePage : ContentPage
    {
        public ClientePage()
        {
            InitializeComponent();
        }

        private async void OnProcurarClicked(object sender, EventArgs e)
        {
            bool procurar = await DisplayAlert("Confirmação", "Deseja procurar isso?", "Sim", "Não");
            if (procurar)
            {
                // Lógica para procurar os dados
                await DisplayAlert("Resultado", "Dados encontrados!", "OK");
            }
        }

        private async void OnDeletarClicked(object sender, EventArgs e)
        {
            bool deletar = await DisplayAlert("Confirmação", "Deseja apagar isso?", "Sim", "Não");
            if (deletar)
            {
                // Lógica para deletar os dados
                await DisplayAlert("Sucesso", "Dados deletados com sucesso!", "OK");
            }
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            // Lógica para adicionar uma nova linha de entrada, se necessário
        }

        private void OnConfirmarClicked(object sender, EventArgs e)
        {
            // Lógica para confirmar a operação
        }
    }
}
