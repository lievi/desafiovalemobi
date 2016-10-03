using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia.DAL;

namespace Servico
{
    public class MercadoriaServico
    {
        //Instanciando classe da persistencia
        public MercadoriaDAL _mercadoriaDAL = new MercadoriaDAL();

        //Listar
        public IQueryable<Mercadoria> Listar()
        {
            return _mercadoriaDAL.Listar();
        }

        //Adicionar
        public void Adicionar(Mercadoria novo)
        {
            _mercadoriaDAL.Adicionar(novo);
        }
    }
}
