using BL.Esencia_de_cafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Esencia_de_Cafe
{
    public partial class RegistroProductos : Form
    {

        ProductosBL _productos;
        public RegistroProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();

            productoBindingSource.DataSource = _productos.ObtenerProductos();
        }

        private void RegistroProductos_Load(object sender, EventArgs e)
        {

        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            productoBindingSource.EndEdit();
            var producto = (Producto)productoBindingSource.Current;

            var Resultado = _productos.guardarProducto(producto);

            if (Resultado == true)
            {
                productoBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Error al guardar Producto");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.agregarProductos();
            productoBindingSource.MoveLast();

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var id = Convert.ToInt32(idTextBox.Text);
                var Resultado = _productos.EliminarProducto(id);

                if (Resultado == true)
                {
                    productoBindingSource.ResetBindings(false);

                }
                else
                {
                    MessageBox.Show("Ocurrio un Problema al eliminar un Producto");
                }
            }
        }

        private void productoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

       
    }
}
