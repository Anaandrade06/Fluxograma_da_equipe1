
using diagrma;
using Microsoft.Maui.Controls;
using Modelos;

namespace Fluxograma_da_equipe1
{
    public partial class CadastroClientePage : ContentPage
        {

            public Cliente cliente { get; set; }
            Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        public CadastroClientePage()
        {
            InitializeComponent();

        }

          void VoltarClicked(object sender, EventArgs e)
            {
                Application.Current.MainPage = new MainPage();
            }

  //--------------------------------------------------------------------------------------------------

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
            IdLabel.Text        = cliente.Id.ToString();
            NomeEntry.Text      = cliente.Nome;
            DatadenascimentoEntry.Text = cliente.Datadenascimento;
            TelefoneEntry.Text  = cliente.telefone;
            }
        }

        //--------------------------------------------------------------------------------------------------
        // Método para limpar os dados da Entry
        private async void OnApagarClienteClicked(object sender, EventArgs e)
        {

            if (cliente == null || cliente.Id < 1)
            await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
            else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse cliente?","Excluir Cliente","cancelar")) // Caso o usuário tocar no Botão "Excluir Cliente"
            {
            // Apaga do Banco de Dados
            clienteControle.Apagar(cliente.Id);

            Application.Current.MainPage = new ListaClientePage(); 
            }
        }

        //--------------------------------------------------------------------------------------------------

        private async void OnSalvarDadosClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos()) 
            {

            var cliente = new Modelos.Cliente();
            if (!String.IsNullOrEmpty(IdLabel.Text))
                cliente.Id      = int.Parse(IdLabel.Text);
            else
                cliente.Id      = 0;
            cliente.Nome      = NomeEntry.Text;
            IdLabel.Text        = cliente.Id.ToString();
            NomeEntry.Text      = cliente.Nome;
            DatadenascimentoEntry.Text = cliente.Datadenascimento;
            TelefoneEntry.Text  = cliente.telefone;


            clienteControle.CriarOuAtualizar(cliente);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            }
            Application.Current.MainPage= new ListaClientePage();
        }

        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            throw new NotImplementedException();
        }

        private async void SalvarClicked(object sender, EventArgs e)
        {
            
            bool salvar = await DisplayAlert("Confirmação", "Deseja salvar isso?", "Sim", "Não");
            if (salvar)
            {

                await DisplayAlert("Sucesso", "Dados salvos com sucesso!", "OK");  
                Application.Current.MainPage= new ListaClientePage();
      
            }
        }

        private async void ExcluirClicked(object sender, EventArgs e)
        {
            bool excluir = await DisplayAlert("Confirmação", "Deseja apagar isso?", "Sim", "Não");
            if (excluir)
            {
                // Lógica para excluir os dados
                await DisplayAlert("Sucesso", "Dados excluídos com sucesso!", "OK");
                Application.Current.MainPage= new ClientePage();
            }
            }
        
        
        }
    }
