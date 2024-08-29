using Microsoft.Maui.Controls;

namespace Fluxograma_da_equipe1
{
    public partial class CadastroProdutoPage : ContentPage
    {
        public CadastroProdutoPage()
        {
            InitializeComponent();
        }

        // Event handler for save button
        private void OnSaveClicked(object sender, EventArgs e)
        {
            // Implementar lógica de salvar
            DisplayAlert("Salvar", "Produto salvo com sucesso", "OK");
             Application.Current.MainPage= new ProdutoPage();
        }

        // Event handler for delete button
        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Implementar lógica de apagar
            DisplayAlert("voltar", "Produto apagado com sucesso", "OK");
             Application.Current.MainPage= new ProdutoPage();
        }
    }
}
