using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linqdinue
using System.Text;
using System.Windows.Forms;

namespace EjemploLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //nuevo login
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //validamos que se haya ingresado un usuario
            if((txtUsuario.Text ==""))
            {
            MessageBox.Show("Se debe ingresar un usuario.");
            returm;
            }
            //Validamos que se haya ingresado una contraseña
            if((txtContresena.Text == ""))
            {
            MessageBox.Show("Se debe ingresar una Contraseña.");
            returm;
            }
        }
    }
}
