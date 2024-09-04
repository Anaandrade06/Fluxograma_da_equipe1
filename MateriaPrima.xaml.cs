using Microsoft.Maui.Controls;
using YourNamespace;

namespace Fluxograma_da_equipe1
{
    public partial class MateriaPrimaPage : ContentPage
    {
        public MateriaPrimaPage()
        {
            InitializeComponent();
        }

        // Event handler for save button
        private void OnSaveClicked(object sender, EventArgs e)
        {
             Application.Current.MainPage= new CortePage();
            // Implementar lógica de salvar
            DisplayAlert("Salvar", "Matéria Prima salva com sucesso", "OK");
        }

        // Event handler for back button
        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage= new MainPage();

            // Implementar lógica para voltar à página anterior
            Navigation.PopAsync();
        }
    }
}
