using Fluxograma_da_equipe1;
using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class CortePage : ContentPage
    {
        public CortePage()
        {
            InitializeComponent();
        }

        // Event handler for save button
        private void OnSaveClicked(object sender, EventArgs e)
        {
            // Implementar lógica de salvar
            DisplayAlert("Salvar", "Informações do corte salvas com sucesso", "OK");
             Application.Current.MainPage= new MainPage();
        }

        // Event handler for delete button
        private void OnDeleteClicked(object sender, EventArgs e)
        {
            // Implementar lógica de apagar
            var answer = DisplayAlert("Apagar", "Deseja apagar estas informações?", "Sim", "Não");
            if (answer.Result)
            {
                // Código para apagar os dados do corte
                DisplayAlert("Apagar", "Informações apagadas com sucesso", "OK");
                 Application.Current.MainPage= new MainPage();
            }
        }
    }
}
