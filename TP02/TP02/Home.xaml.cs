
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();

        }

        async void btn_DetalheView(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = Nome.Text,
                Idade = int.Parse(Idade.Text),
                Profissao = Profissao.Text,
                Pais = Pais.Text
            };
            var detalhe = new DetalheView();
            detalhe.BindingContext = contato;
            await Navigation.PushAsync(detalhe);
        }
    }
}