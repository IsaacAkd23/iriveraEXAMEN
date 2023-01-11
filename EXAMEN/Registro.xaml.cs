using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EXAMEN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUusario.Text = "Bienvenido " + usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double MontoInicial = Convert.ToDouble(txtMInicial.Text);
            
            double PagoMensual = (((4000 - MontoInicial)/5)+((4000 *5)/100));
            txtPMensual.Text = PagoMensual.ToString();

      
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            Navigation.PushAsync(new Resumen(usuario));
        }
    }
}