using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_2._1
{
    public partial class Form1 : Form
    {
        Inventario inventario;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (inventario.Buscar(txtNombre.Text) == null) {
                MessageBox.Show("El producto que usted busca no sé encuentra en el inventario.");
                txtNombre.Focus();
                txtCodigo.Text = "";
                txtCantidad.Text = "";
                txtCosto.Text = "";
            }
            else {
                txtCodigo.Text = inventario.Buscar(txtNombre.Text).codigo.ToString();
                txtCantidad.Text = inventario.Buscar(txtNombre.Text).cantidad.ToString();
                txtCosto.Text = inventario.Buscar(txtNombre.Text).costo.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inventario = new Inventario();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (inventario.Eliminar(txtNombre.Text) == true) {
                MessageBox.Show(txtNombre.Text + " fue eliminado del inventario.");
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtCantidad.Text = "";
                txtCosto.Text = "";
            }
            else {
                MessageBox.Show("El producto que usted desea eliminar no sé encuentra en el inventario.");
            }
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Producto nuevoP = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text));
            inventario.Agregar(nuevoP);
            MessageBox.Show(nuevoP.nombre + " fue añadido al inventario.");
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtCosto.Text = "";
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            txtLista.Text = inventario.Reporte();
        }
    }
}
