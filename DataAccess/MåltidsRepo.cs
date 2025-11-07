using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using Models;

namespace DAL
{
    public class MåltidsRepo : IRepository<Måltid>
    {
        private List<Måltid> måltidslista;

        public MåltidsRepo()
        {
            måltidslista = new List<Måltid>();
        }

        public void Add(Måltid måltid)
        {
            måltidslista.Add(måltid);
            
        }

        public List<Måltid> GetAll()
        {
            return måltidslista;
        } 

        public Måltid? GetById(int id)
        {
            foreach(Måltid m in måltidslista)
            {
                if (m.Id == id)
                {
                    return m;
                }
            }
            return null;
        }

        public bool Update(Måltid måltid)
        {
            for(int i =0; i< måltidslista.Count; i++)
            {
                if (måltidslista[i].Id == måltid.Id)
                {
                    måltidslista[i] = måltid;
                    return true;
                }
            }
            return false;
        }

        public bool Delete(Måltid måltid)
        {
            for(int i = 0; i< måltidslista.Count; i++)
            {
                if (måltidslista[i].Id == måltid.Id)
                {
                    måltidslista.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}
