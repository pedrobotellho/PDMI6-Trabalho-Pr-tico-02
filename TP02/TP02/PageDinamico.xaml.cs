
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDinamico : ContentPage
    {
        public PageDinamico()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);

            InitializeComponent();

        }

        private void btn_AlterarEstilo(object sender, EventArgs e)
        {
            Random rnd = new Random();

            Color randomColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            labelClock.TextColor = randomColor;

        }

        bool OnTimerTick()
        {
            labelClock.Text = "Horário\n";
            labelClock.Text += DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            return true;
        }
    }
}