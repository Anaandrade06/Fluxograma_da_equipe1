using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Fluxograma_da_equipe1
{
    public partial class CadastroCliente : ContentPage
    {
        public ObservableCollection<string> Fields { get; set; }

        public ICommand ConfirmCommand { get; }
        public ICommand DeleteCommand { get; }

        public CadastroCliente()
        {
            InitializeComponent();

            Fields = new ObservableCollection<string>
            {
                "Field 1",
                "Field 2",
                "Field 3",
                "Field 4"
            };

            ConfirmCommand = new Command(OnConfirm);
            DeleteCommand = new Command(OnDelete);

            BindingContext = this;
        }
        private void OnAddFieldClicked(object sender, EventArgs e)
        {
            Fields.Add($"Field {Fields.Count + 1}");
        }
        private void OnConfirm()
        {
            // Add your confirmation logic here
            DisplayAlert("Confirm", "Deseja salvar isso?", "SIM", "NÃO");
        }
        private void OnDelete()
        {
            // Add your deletion logic here
            DisplayAlert("Delete", "Deseja apagar isso?", "SIM", "NÃO");
        }
        private void OnSaveYesClicked(object sender, EventArgs e)
        {
            // Logic for save confirmation
        }
        private void OnSaveNoClicked(object sender, EventArgs e)
        {
            // Logic for save cancellation
        }
        private void OnDeleteYesClicked(object sender, EventArgs e)
        {
            // Logic for delete confirmation
        }
        private void OnDeleteNoClicked(object sender, EventArgs e)
        {
            // Logic for delete cancellation
        }
    }
}
