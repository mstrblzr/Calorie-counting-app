using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dag
    {
        public List<Måltid> allamåltider = new List<Måltid>();
        public DateTime date1;
        public int Id;
        public Dag(int id, List<Måltid> måltidsrepo, DateTime datum)
        {
            foreach (Måltid måltid in måltidsrepo)
            {
                
                
                    allamåltider.Add(måltid);
                
            }
            this.date1 = datum;
            this.Id = id;
        }
        
        public Dag()
        {

        }
        //public void FyllLista(Måltid frukost, Måltid lunch, Måltid middag, Måltid mellanmål)
        //{
        //    allamåltider.Add(frukost, lunch, middag, mellanmål);
        //}

        public void SkrivUtLista()
        {
            foreach (Måltid m in allamåltider)
            {
                Console.WriteLine(m.Namn + ": " + m.GetMat() + m.RäknaKalorier());
            }
        }
    }
}
