using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EXAMEN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario)
        {
            InitializeComponent();
            lblUusario.Text = "Bienvenido " + usuario;
        }

        private void btnAcerca_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("NOVENO A", "ISAAC RIVERA ", "Cerrar");
        }
    }
}