using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccess
{
    internal class DagRepo : IRepository<Dag>
    {
        public List<Dag> DagsLista;

        public DagRepo()
        {

        }

        public void Add(Dag dag)
        {
            DagsLista.Add(dag);
        }

        public List<Dag> GetAll()
        {
            return DagsLista;
        }

        public Dag? GetById(int id)
        {
            foreach(Dag dag in DagsLista)
            {
                if(dag.Id == id)
                {
                    return dag;
                }
            }
            return null;
        }

        public bool Update(Dag dag)
        {
            for(int i =0; i< DagsLista.Count; i++)
            {
                if(dag.Id == DagsLista[i].Id)
                {
                    DagsLista[i] = dag;
                    return true;
                }
            }
            return false;
        }

        public bool Delete(Dag dag)
        {
            for(int i = 0; i< DagsLista.Count; i++)
            {
                if(dag.Id == DagsLista[i].Id)
                {
                    DagsLista.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

    }
}
