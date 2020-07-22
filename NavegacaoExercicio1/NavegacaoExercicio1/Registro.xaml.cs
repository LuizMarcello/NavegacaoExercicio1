using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavegacaoExercicio1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private async void Salvar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                await DisplayAlert("Nome Inválido","Informe o nome do usuário","OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                await DisplayAlert("Email Inválido", "Informe o e-mail do usuário", "OK");
                return;
            }

            await Navigation.PushAsync(new Login());
        }

        private async void Cancelar_Clicked_1(object sender, EventArgs e)
        {
            var resposta = await DisplayActionSheet("Cancelar","Deseja cancelar o registro ?",null,"Sim","Não");

            if (resposta == "Sim")
                await Navigation.PopAsync();
        }

        
    }
}
               