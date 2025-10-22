using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaloriräknarapp
{
    public class Dag
    {
        public List<Måltider> allamåltider = new List<Måltider>();
        public DateTime date1 = DateTime.Now;
        public Dag(List<Måltider> måltider)
        {
            allamåltider.AddRange(måltider);
        }
        public Dag()
        {

        }
        public void FyllLista(Måltider frukost, Måltider lunch, Måltider middag, Måltider mellanmål)
        {
            allamåltider.AddRange(frukost, lunch, middag, mellanmål);
        }

        public void SkrivUtLista()
        {
            foreach(Måltider m in allamåltider)
            {
                Console.WriteLine(m.namn+": "+m.GetMat()+ m.RäknaKalorier());
            }
        }
    }
}
