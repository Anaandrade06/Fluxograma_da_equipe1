using Microsoft.Maui.Controls;

namespace Fluxograma_da_equipe1
{
    public partial class ClientePage: ContentPage
    {
        public ClientePage()
        {
            InitializeComponent();
        }
        private void VoltarClienteClicked (object sender, EventArgs e)
        {
          Application.Current.MainPage= new MainPage();
        }
         private void CadastrarClienteClicked (object sender, EventArgs e)
        {
          Application.Current.MainPage= new CadastroClientePage();
        }
        // Aqui você pode adicionar event handlers e outras lógicas
    }
}
