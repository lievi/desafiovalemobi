using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia.DAL;

namespace Servico
{
    public class TipoServico
    {
        //Instanciando a classe DAL
        private TipoDAL _tipoDAL = new TipoDAL();

        //Listar
        public IQueryable<Tipo> Listar()
        {
            return _tipoDAL.Listar();
        }

        //Adicionar
        public void Adicionar(Tipo novo)
        {
            _tipoDAL.Inserir(novo);
        }

        //Deletar
        public void Deletar(int id)
        {
            _tipoDAL.Deletar(id);
        }
    }
}
