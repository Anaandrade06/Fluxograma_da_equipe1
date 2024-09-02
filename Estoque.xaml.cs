using Microsoft.Maui.Controls;

namespace Fluxograma_da_equipe1
{
    public partial class EstoquePage : ContentPage
    {
        public EstoquePage()
        {
            InitializeComponent();
        }

        // Event handler for save button
        private void OnSaveClicked(object sender, EventArgs e)
        {
        Application.Current.MainPage= new MainPage();

            // Implementar lógica de salvar
            DisplayAlert("Salvar", "Estoque salvo com sucesso", "OK");
        }

        // Event handler for delete button
        private void OnDeleteClicked(object sender, EventArgs e)
        {
            // Implementar lógica de apagar
            var answer = DisplayAlert("Apagar", "Deseja apagar este estoque?", "Sim", "Não");
            if (answer.Result)
            {
                Application.Current.MainPage= new MainPage();

                // Código para apagar o estoque
                DisplayAlert("Apagar", "Estoque apagado com sucesso", "OK");
            }
        }
    }
}
