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
using YoutubeApp.Vistas;

namespace YoutubeApp
{
    public partial class Main : Form
    {
        DataTable ListaUsuarios;
        Usuarios usuarios = new Usuarios();
        public Main()
        {
            InitializeComponent();
            CargarDatos();

        }

        private void CargarDatos()
        {
            ListaUsuarios = usuarios.GetUsuarios();
            CargardataGrid();
        }

        private void CargardataGrid()
        {
            dgv_usuarios.DataSource = null; 
            dgv_usuarios.DataSource = ListaUsuarios; 
        }

        private void btn_getUsuario_Click(object sender, EventArgs e)
        {
            ListaUsuarios = usuarios.GetUsuario(txt_nombreUsuario.Text);
            CargardataGrid();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //agregar / editar usuario
            var usuarioVista = new UsuarioVista();
            usuarioVista.ShowDialog();

            //recargar datagrid
            CargarDatos();
        }
    }
}
