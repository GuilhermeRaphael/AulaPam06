using Microsoft.Maui.Controls;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNormalTip(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(billInput.Text);
            double percentualDaGorjeta = tipPercentSlider.Value;

            double gorjeta = valor * (percentualDaGorjeta / 100);
            double total = valor + gorjeta;

            //Manipular para aparecer em um elemento que ja existe
            tipOutput.Text = gorjeta.ToString(); // Convert.ToString(gorjeta)
            totalOutput.Text = total.ToString(); // Convert.ToString(total)
        }

        private void OnGenerousTip(object sender, EventArgs e)
        {

        }
        
    }

}
