using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
//Trabaje

namespace pjVentaHeredada
{
    public partial class frmCredito : Form
    {
        static int[] letras = { 3, 6, 9, 12 };
        static string[] productos = { "Lavadora", "Refrigeradora", "Licuadora", "Extractora", "DVD", "Radiograbadora", "Bluray" };
        double tSubtotal = 0;
        public frmCredito()
        {
            InitializeComponent();
        }

        private void frmCredito_Load(object sender, EventArgs e)
        {
            cboLetras.DataSource = letras;
            cboProducto.DataSource = productos;
            MostrarFechas();
            MostrarHora();
            lblMonto.Text = "0.00";

        }
        private void MostrarHora()
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void MostrarFechas()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            //Objeto de la clase credito
            Credito objCr = new Credito();

            //Datos del cliente
            objCr.Cliente = txtCliente.Text;
            objCr.RUC = txtRUC.Text;
            objCr.Fecha = DateTime.Parse(lblFecha.Text);
            objCr.Fecha = DateTime.Parse(lblFecha.Text);

            //Datos del producto
            objCr.Producto = cboProducto.Text;
            objCr.Cantidad = int.Parse(txtCantidad.Text);

            //imprimiendo en la lista
            ListViewItem fila = new ListViewItem(objCr.GetX().ToString());
            fila.SubItems.Add(objCr.Producto);
            fila.SubItems.Add(objCr.Cantidad.ToString());
            fila.SubItems.Add(objCr.AsignaPrecio().ToString());
            fila.SubItems.Add(objCr.CalculaSubtotal().ToString());
            lvDetalle.Items.Add(fila);
            tSubtotal += objCr.CalculaSubtotal();
            lblMonto.Text = tSubtotal.ToString("0.00");

        }

    }
}
