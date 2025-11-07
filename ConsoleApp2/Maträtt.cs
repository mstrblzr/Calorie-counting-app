using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models

{
    public class Maträtt
    {
        public int Id { get; set; }
        public int Kalorier { get; set; }
        public string Namn { get; set; }
        public Maträtt(int id,  int kalorier,string namn)
        {

            this.Id = id;
            this.Namn = namn;
            this.Kalorier = kalorier;
        }
        public Maträtt()
        {

        }
       
    }
}
