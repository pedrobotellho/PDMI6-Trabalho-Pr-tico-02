using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace TP02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private async void btn_Padrao(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagePadrao());
        }
        private async void btn_Dinamico(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageDinamico());
        }
        private async void btn_TriggersView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TriggersView());
        }
        private async void btn_Home(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
        private async void btn_ListViewSimples(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewSimples());
        }
        private async void btn_FormProduto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormProduto());
            var produto = new Produto();

            var detalhe = new FormProduto();
            detalhe.BindingContext = produto;
            await Navigation.PushAsync(detalhe);

        }

    }
}