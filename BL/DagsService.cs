using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BL
{
    public class DagsService : IDagsService
    {
        public IRepository<Dag> dagsrepo;
        public DagsService(IRepository<Dag> repo) 
        { 
        dagsrepo = repo;
        }
        public void Add(Dag dag)
        {
            this.dagsrepo.Add(dag);
        }

        public List<Dag> GetAll()
        {
         return this.dagsrepo.GetAll();
        }
        public Dag? GetById(int id)
        {
          return this.dagsrepo.GetById(id);
        }
        public bool Update(Dag dag)
        {
          return this.dagsrepo.Update(dag);
        }
        public bool Delete(Dag dag)
        {
          return this.dagsrepo.Delete(dag);
        }
    }
}
