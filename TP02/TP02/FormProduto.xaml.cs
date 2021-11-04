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
    public partial class FormProduto : ContentPage
    {
        public FormProduto()
        {
            InitializeComponent();

        }
        async void btn_ProdutoView(object sender, EventArgs e)
        {
            var produto = new Produto
            {
                Id = int.Parse(Id.Text),
                Descricao = Descricao.Text,
                Categoria = Categoria.Text,
                Quantidade = int.Parse(Quantidade.Text),
                Preco = decimal.Parse(Preco.Text)
            };

            var detalhe = new FormProduto();
            detalhe.BindingContext = produto;
            await Navigation.PushAsync(detalhe);
        }
        public async void OnPreviousPageButtonClicked(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}