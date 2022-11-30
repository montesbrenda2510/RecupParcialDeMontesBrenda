using RecupParcialDeMontesBrenda.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupParcialDeMontesBrenda.Datos
{
    public class RepocitorioDeCubo
    {
        private List<Cubo> listaCubos;
        private bool hayCambios = false;
        public RepocitorioDeCubo()
        {
            listaCubos = new List<Cubo>();

        }
        public void Agregar(Cubo cubo)
        {
            listaCubos.Add(cubo);
            hayCambios = true;
        }
        public void Borrar(Cubo cubo)
        {
            listaCubos.Remove(cubo);
            hayCambios = true;
        }
        public void Editar(Cubo cubo)
        {
            hayCambios = true;
        }
        public List<Cubo> GetLista()
        {
            return listaCubos;
        }
        public int GetCantidad()
        {
            return listaCubos.Count;
        }
    }

}
