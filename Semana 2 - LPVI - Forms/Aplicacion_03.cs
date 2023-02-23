using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Semana_2___LPVI___Forms
{
    public partial class Aplicacion_03 : Form
    {
        public Aplicacion_03()
        {
            InitializeComponent();
        }

        string [] clientes = new string[] { "Robert", "Emilio", "Carlos","Bruno","Juan","Daniel","Eduardo" };
        string[] descripcion = new string[] { "Doctor", "Mecanico", "Profesor","Arquitecto","Analista","Electricista","Veterinario" };

        private void Aplicacion_03_Load(object sender, EventArgs e)
        {
            cmbcliente.Items.AddRange(clientes );
        }
 private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdescripcion.Text = descripcion[cmbcliente.SelectedIndex].ToString();
            string ruta = Application.StartupPath.Substring(0, Application.StartupPath.Length - 9);
           pictureBox1.Image = Image.FromFile(ruta + "imagen\\" +
             Convert.ToString(cmbcliente.SelectedIndex) + ".BMP");
            //pictureBox1.Image = Image.FromFile("imagen\\" +
                //       Convert.ToString(cmbcliente.SelectedIndex) + ".BMP");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

       
    }
}