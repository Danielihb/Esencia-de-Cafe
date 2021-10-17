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

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e) //Guardar producto
        {
            productoBindingSource.EndEdit();
            var producto = (Producto)productoBindingSource.Current;

            var Resultado = _productos.guardarProducto(producto);

            if (Resultado.Exitoso == true)
            {
                productoBindingSource.ResetBindings(false);
                DesabilitarHabilitarBonotes(true);
            }
            else
            {
                MessageBox.Show(Resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) //Agregar Producto
        {
            _productos.agregarProductos();
            productoBindingSource.MoveLast();

            DesabilitarHabilitarBonotes(false);

        }

        private void DesabilitarHabilitarBonotes(bool valor) //Desabilitar botones mientras un producto esta ingresando un producto.
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButton1.Visible =! valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) //Eliminar Producto
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea Eliminar este este Producto?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);   
                }
                    
            }
        }

        private void Eliminar(int id)
        {
            
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

        private void productoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e) //Boton Cancelar
        {
            DesabilitarHabilitarBonotes(true);
            Eliminar(0);
        }

        private void productoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            
        }
    }
}
