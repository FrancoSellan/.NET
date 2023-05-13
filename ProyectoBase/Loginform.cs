using ProyectoBase.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBase
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario(txtUsuario.Text, txtPassword.Text);

            string usuCorrecto = "Franco";
            string passwordCorrecto = "123456";

            if (txtUsuario.Text.Equals(usuCorrecto) && txtPassword.Text.Equals(passwordCorrecto))
            {
                // Nombre de usuario y password correctos
                PrincipalForm ventana = new PrincipalForm(usu);
                ventana.Show();
                this.Hide();
            }
            else
            {
                // Nombre de usuario o password incorrectos
                MessageBox.Show("Ingrese valores correctos");
            }
            
        }
    }
}
