using NavegacaoExercicio1.Model;
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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            if (string.IsNullOrWhiteSpace(txtNomeDoUsuario.Text))
            {
                await DisplayAlert("Atenção!","Informe um nome de usuário válido","OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                await DisplayAlert("Atenção!","Informe uma senha válida","OK");
            }

            if (txtNomeDoUsuario.Text == ("xamarin") && txtSenha.Text == ("123456"))
            {
                usuario.Nome = txtNomeDoUsuario.Text;
                usuario.Senha = txtSenha.Text;
                await Navigation.PushAsync(new BemVindo(usuario));
            }
            else
            {
                await Navigation.PushModalAsync(new Erro());
            }
        }

        private async void Cancelar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}