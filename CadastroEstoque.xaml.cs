using Microsoft.Maui.Controls;

namespace Fluxograma_da_equipe1
{
    public partial class CadastroEstoquePage : ContentPage
    {
        public CadastroEstoquePage()
        {
            InitializeComponent();
        }

        // Event handler for save button
        private void OnSaveClicked(object sender, EventArgs e)
        {
            // Implementar lógica de salvar
            DisplayAlert("Salvar", "Estoque salvo com sucesso", "OK");
        }

        // Event handler for delete button
        private void OnDeleteClicked(object sender, EventArgs e)
        {
            // Implementar lógica de apagar
            DisplayAlert("Apagar", "Estoque apagado com sucesso", "OK");
        }
    }
}
