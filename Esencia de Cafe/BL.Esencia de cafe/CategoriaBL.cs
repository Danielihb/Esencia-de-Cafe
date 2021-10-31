using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Esencia_de_cafe
{
    public class CategoriaBL
    {
        contexto _contexto;

        public BindingList<Categoria> ListaCategorias { get; set; }

        public CategoriaBL()
        {

            _contexto = new contexto();
                ListaCategorias = new BindingList<Categoria>();
        }

        public BindingList<Categoria> ObtenerCategorias()
        {

            _contexto.Categorias.Load();
            ListaCategorias = _contexto.Categorias.Local.ToBindingList();


            return ListaCategorias;
        }
    }

    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
