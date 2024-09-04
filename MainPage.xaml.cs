using Microsoft.Maui.Controls;

namespace Fluxograma_da_equipe1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Event handlers for each button
        private async void OnClienteClicked(object sender, EventArgs e)
        {
			Application.Current.MainPage= new CadastroClientePage();
            // Navegação ou ação ao clicar em "Cliente"
            await DisplayAlert("Cliente", "Você clicou em Cliente", "OK");
            // Navegar para a página de Cliente, se necessário
            // await Navigation.PushAsync(new ClientePage());
        }

        private async void OnFornecedorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage= new FornecedorPage();
            // Navegação ou ação ao clicar em "Fornecedor"
            await DisplayAlert("Fornecedor", "Você clicou em Fornecedor", "OK");
            // Navegar para a página de Fornecedor, se necessário
            // await Navigation.PushAsync(new FornecedorPage());
        }

        private async void OnProdutoClicked(object sender, EventArgs e)
        {
             Application.Current.MainPage= new ProdutoPage();
            // Navegação ou ação ao clicar em "Produto"
            await DisplayAlert("Produto", "Você clicou em Produto", "OK");
            // Navegar para a página de Produto, se necessário
            // await Navigation.PushAsync(new ProdutoPage());
        }

        private async void OnEstoqueClicked(object sender, EventArgs e)
        {
             Application.Current.MainPage= new EstoquePage();
            // Navegação ou ação ao clicar em "Estoque"
            await DisplayAlert("Estoque", "Você clicou em Estoque", "OK");
            // Navegar para a página de Estoque, se necessário
            // await Navigation.PushAsync(new EstoquePage());
        }

         private async void OnProduçãoClicked(object sender, EventArgs e)
        {
        Application.Current.MainPage= new MateriaPrimaPage();

        }
    }
}
