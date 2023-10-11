using System;
using System.Drawing;
using biblioUsuarios_G2_2024_1;
using System.Collections;
using System.Windows.Forms;
using System.Threading;

namespace Autenticacion_G2_2024_1
{
    public partial class Form1 : Form
    {
        private ArrayList usuarios; //atributo
        public Form1()
        {
            InitializeComponent();
            usuarios = new ArrayList();
            CargarUsuarios();
        }

        private void CargarUsuarios() //metodo
        {
            usuarios.Add(new Usuario("Armando", "armando00"));
            usuarios.Add(new Usuario("Luis", "luis123"));
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (object usuario in usuarios)
            {
                Usuario miUsuario = (Usuario)usuario;

                if (txtbUsuario.Text == miUsuario.NomUsuario && txtbPassword.Text == miUsuario.Password)
                {
                    MessageBox.Show("Ingreso Correcto");
                    break;
                    
                } //En txtbPassword - Propiedad "UseSystemPasswordChar" oculta contraseña, "PasswordChar" elijes caracter para remplazar contraseña 
                else
                {
                    if (contador == usuarios.Count - 1)
                    {
                        MessageBox.Show("Usuario o Contraseña Incorrecto");
                    }
                }
                contador++;
            }
        }
    }
}
