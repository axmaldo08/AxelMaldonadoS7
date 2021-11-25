using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using AxelMaldonadoS7.Models;

namespace AxelMaldonadoS7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private SQLiteAsyncConnection con;
        public Registro()
        {
            InitializeComponent();
            con = DependencyService.Get<DataBase>().GetConnection();
        }

        private void btnAgregar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var Registros = new Estudiante { Nombre = txtNombre.Text, Usuario = txtUsuario.Text, Contrasenia = txtContasenia.Text };
                con.InsertAsync(Registros);

                DisplayAlert("Mensaje de alerta", "Dato ingresado correctamente", "OK");

                limpiarFormulario();
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", ex.Message, "OK");
            }

        }
        void limpiarFormulario()
        {
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtContasenia.Text = "";
        }
    }
}