using Microsoft.Maui.Controls;

namespace Fluxograma_da_equipe1
{
    public partial class ProdutoPage : ContentPage
    {
        public ProdutoPage()
        {
            InitializeComponent();
        }

        // Event handler for search button
        private void OnSearchClicked(object sender, EventArgs e)
        {
            // Implementar lógica de busca
            DisplayAlert("Busca", "Pesquisa realizada", "OK");
        }

        // Event handler for save button
        private void OnSaveClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage= new CadastroProdutoPage();
        }
        // Event handler for delete button
        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage= new MainPage();
        } 
        }
    }
