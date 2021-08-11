using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeApp.Database;

namespace YoutubeApp.Vistas
{
    public partial class UsuarioVista : Form
    {
        public UsuarioVista()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios() 
            {
                Nombre = txt_nombre.Text,
                Apellido = txt_apellido.Text,
                Clave = txt_clave.Text,
                Edad = (int)txt_edad.Value,
                NombreUsuario = txt_nombreUsuario.Text
            };

            //usuario.Nombre = txt_nombre.Text;

            usuario.InsertUsuario();
            LimpiarUsuario();
            this.Close();
        }

        private void LimpiarUsuario()
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_clave.Clear();
            txt_edad.Value = 0;
            txt_nombreUsuario.Clear();
        }
    }
}
