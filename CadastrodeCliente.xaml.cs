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
        private void SalvarClicked (object sender, EventArgs e)
        {
          Application.Current.MainPage= new ClientePage();
        }
    
        private void VoltarClicked (object sender, EventArgs e)
        {
          Application.Current.MainPage= new ClientePage();
        }
        
    }
}
