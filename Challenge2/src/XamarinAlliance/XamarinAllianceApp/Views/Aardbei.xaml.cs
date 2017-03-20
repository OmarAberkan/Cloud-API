using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAllianceApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aardbei : ContentPage
    {
        public Aardbei()
        {
            InitializeComponent();
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
             Navigation.PopModalAsync();
        }
    }
}
