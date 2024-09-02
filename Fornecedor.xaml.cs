using Microsoft.Maui.Controls;

namespace Fluxograma_da_equipe1
{
    public partial class FornecedorPage : ContentPage
    {
        public FornecedorPage()
        {
            InitializeComponent();
        }
          private void CadastrarFornecedorClicked (object sender, EventArgs e)
        {
          Application.Current.MainPage= new CadastroFornecedor();
        }
          private void VoltarClicked (object sender, EventArgs e)
        {
          Application.Current.MainPage= new MainPage();
        }
        // Aqui você pode adicionar event handlers e outras lógicas
    }
} 