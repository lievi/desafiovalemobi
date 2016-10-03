using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.Entity;

namespace Persistencia.DAL
{
    
    public class MercadoriaDAL
    {
        //Instanciando banco
        private Contexto db = new Contexto();
        
        //Adicionar Mercadorias
        public void Adicionar(Mercadoria novo)
        {
            db.Mercadoria.Add(novo);
            db.SaveChanges();
        }
        //Listar Mercadorias
        public IQueryable<Mercadoria> Listar()
        {
            return db.Mercadoria.OrderBy(x => x.NomeMercadoria).Include(t =>t.Tipo).OrderBy(x => x.NomeMercadoria);
        }
    }
}
