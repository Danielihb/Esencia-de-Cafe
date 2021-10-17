using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Esencia_de_cafe
{
    public class ProductosBL
    {
        public BindingList<Producto> ListaProductos { get; set; }
        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.id = 1;
            producto1.Categorias = "Bebidas";
            producto1.Descripcion = "Cafe Con Leche";
            producto1.Precio = 27.00;
            producto1.Activo = true;

            ListaProductos.Add(producto1);

            var producto2 = new Producto();
            producto2.id = 2;
            producto2.Categorias = "Bebidas";
            producto2.Descripcion = "Cafe Doble";
            producto2.Precio = 30.00;
            producto2.Activo = true;

            ListaProductos.Add(producto2);

            var producto3 = new Producto();
            producto3.id = 3;
            producto3.Categorias = "Bebidas";
            producto3.Descripcion = "Capuchino";
            producto3.Precio = 34.00;
            producto3.Activo = true;

            ListaProductos.Add(producto3);

            var producto4 = new Producto();
            producto4.id = 4;
            producto4.Categorias = "Bebidas";
            producto4.Descripcion = "Cafe en Jarrito";
            producto4.Precio = 25.00;
            producto4.Activo = true;

            ListaProductos.Add(producto4);

            var producto5 = new Producto();
            producto5.id = 5;
            producto5.Categorias = "Acompañantes";
            producto5.Descripcion = "Budin de Pan";
            producto5.Precio = 15.00;
            producto5.Activo = true;

            ListaProductos.Add(producto5);

            var producto6 = new Producto();
            producto6.id = 6;
            producto6.Categorias = "Acompañantes";
            producto6.Descripcion = "Flan";
            producto6.Precio = 18.00;
            producto6.Activo = true;

            ListaProductos.Add(producto6);

            var producto7 = new Producto();
            producto7.id = 7;
            producto7.Categorias = "Acompañantes";
            producto7.Descripcion = "Brownie";
            producto7.Precio = 23.00;
            producto7.Activo = true;

            ListaProductos.Add(producto7);
        }

        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }
        public Resultado guardarProducto(Producto producto) //guardar producto
        {
            var resultado = Validar(producto);
            if(resultado.Exitoso == false)
            {
                return resultado;
            }

            if (producto.id == 0)
            {
                producto.id = ListaProductos.Max(item => item.id) + 1;

            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void agregarProductos() //agregar un nuevo producto.
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id) //Eliminar Producto.
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.id == id)
                {
                    ListaProductos.Remove(producto);
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Producto producto) //Validaciones
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if(string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(producto.Categorias) == true)
            {
                resultado.Mensaje = "Ingrese una Categoria";
                resultado.Exitoso = false;
            }

            if (producto.Precio <= 0 )
            {
                resultado.Mensaje = "El precio debe ser mayor que Cero (0)";
                resultado.Exitoso = false;
            }
            return resultado;
        }
    }
    public class Producto
    {
        public int id { get; set; }
        public string Categorias { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public bool Activo { get; set; }
    }
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}

