using Microsoft.Maui.Controls;

namespace Fluxograma_da_equipe1
{
    public partial class FornecedorPage : ContentPage
    {
        public FornecedorPage()
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

        private async void OnApagarClicked(object sender, EventArgs e)
        {
            bool apagar = await DisplayAlert("Confirmação", "Deseja apagar isso?", "Sim", "Não");
            if (apagar)
            {
                // Lógica para apagar os dados
                await DisplayAlert("Sucesso", "Dados apagados com sucesso!", "OK");
            }
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            // Lógica para adicionar uma nova linha de entrada, se necessário
        }
    }
}
