using Microsoft.Maui.Controls;
using Modelos;

namespace Fluxograma_da_equipe1
{
    public partial class CadastroClientePage : ContentPage
        {
        public CadastroClientePage()
        {
            InitializeComponent();
        }

        private async void SalvarClicked(object sender, EventArgs e)
        {
            bool salvar = await DisplayAlert("Confirmação", "Deseja salvar isso?", "Sim", "Não");
            if (salvar)
            {
                // Lógica para salvar os dados
                await DisplayAlert("Sucesso", "Dados salvos com sucesso!", "OK");  
                Application.Current.MainPage= new ClientePage();
      
            }
        }

        private async void ExcluirClicked(object sender, EventArgs e)
        {
            bool excluir = await DisplayAlert("Confirmação", "Deseja apagar isso?", "Sim", "Não");
            if (excluir)
            {
                // Lógica para excluir os dados
                await DisplayAlert("Sucesso", "Dados excluídos com sucesso!", "OK");
                Application.Current.MainPage= new ClientePage();
            }
            }
        }
    }
