using Microsoft.Maui.Controls;

namespace Fluxograma_da_equipe1
{
    public partial class CadastroFornecedor : ContentPage
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            bool salvar = await DisplayAlert("Confirmação", "Deseja salvar isso?", "Sim", "Não");
            if (salvar)
            {
                // Lógica para salvar os dados
                await DisplayAlert("Sucesso", "Dados salvos com sucesso!", "OK");  
                Application.Current.MainPage= new FornecedorPage();
            }
        }

        private async void OnExcluirClicked(object sender, EventArgs e)
        {
            bool excluir = await DisplayAlert("Confirmação", "Deseja apagar isso?", "Sim", "Não");
            if (excluir)
            {
                // Lógica para excluir os dados
                await DisplayAlert("Sucesso", "Dados excluídos com sucesso!", "OK");
                Application.Current.MainPage= new FornecedorPage();
            }
            }
        }
    }
