using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class Dag
    {
        public List<Måltid> allamåltider = new List<Måltid>();
        public DateTime date1;
        public int Id;
        public Dag(int id, IRepository<Måltid> måltidsrepo, DateTime datum)
        {
            for (int i = 0; i < måltidsrepo.GetAll().Count; i++)
            {
                if (i == måltidsrepo.GetById(i).Id)
                {
                    allamåltider.Add(måltidsrepo.GetById(i));
                }
            }
            this.date1 = datum;
            this.Id = id;
        }
        
        public Dag()
        {

        }
        public void FyllLista(Måltid frukost, Måltid lunch, Måltid middag, Måltid mellanmål)
        {
            allamåltider.AddRange(frukost, lunch, middag, mellanmål);
        }

        public void SkrivUtLista()
        {
            foreach (Måltid m in allamåltider)
            {
                Console.WriteLine(m.Namn + ": " + m.GetMat() + m.RäknaKalorier());
            }
        }
    }
}
