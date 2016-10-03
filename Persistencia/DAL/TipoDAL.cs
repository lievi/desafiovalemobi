using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL
{
    public class TipoDAL
    {
        //Instanciando o banco
        private Contexto db = new Contexto();

        //Inserir Tipo
        public void Inserir(Tipo novo)
        {
            db.Tipo.Add(novo);
            db.SaveChanges();
        }
        //Deletar Tipo
        public void Deletar(int id)
        {
            db.Tipo.Remove(db.Tipo.Where(x => x.TipoId == id).First());
            db.SaveChanges();
        }

        //Listar

        public IQueryable<Tipo> Listar()
        {
            return db.Tipo.OrderBy(x => x.NomeTipo);
        }
    }
}
