using FarmaPrueba.BL;
using System;
using System.Windows.Forms;

namespace FarmaPrueba.win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductos();

            foreach (var producto in listadeProductos)
            {
                MessageBox.Show(producto.Descripcion);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
