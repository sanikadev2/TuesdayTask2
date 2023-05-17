using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        int lblValue = 0;
        public TabbedPage1 ()
        {
            InitializeComponent();
        }

        private void Plus_Button_Clicked(object sender, EventArgs e)
        {
            lblValue++;
            lblCount.Text = lblValue.ToString();
        }

        private void Minus_Button_Clicked(object sender, EventArgs e)
        {
            lblValue--;
            lblCount.Text = lblValue.ToString();
        }
    }
}