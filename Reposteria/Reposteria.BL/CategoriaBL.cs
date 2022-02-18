using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposteria.BL
{
    public class CategoriaBL
    {
        Contexto _contexto;
        public List<Categoria> ListadeCategorias { get; set; }

        public CategoriaBL()
        {
            _contexto = new Contexto();
            ListadeCategorias = new List<Categoria>();
        }

        public List<Categoria> ObtenerCategorias()
        {
            ListadeCategorias = _contexto.Categorias.ToList();
            return _contexto.Categorias.ToList();
        }

        public void GuardarCategoria(Categoria categoria)
        {
            if (categoria.Id == 0)
            {
                _contexto.Categorias.Add(categoria);
            }
            else
            {
                var categoriaExitente = _contexto.Categorias.Find(categoria.Id);
                categoriaExitente.Descripcion = categoria.Descripcion;
                
            }
            _contexto.Categorias.Add(categoria);
            _contexto.SaveChanges();
        }

        public Categoria ObtenerCategoria(int id)
        {
            var categoria = _contexto.Categorias.Find(id);

            return categoria;
        }

        public void EliminarCategoria(int id)
        {
            var categoria = _contexto.Categorias.Find(id);

            _contexto.Categorias.Remove(categoria);
            _contexto.SaveChanges();
        }
    }
}
