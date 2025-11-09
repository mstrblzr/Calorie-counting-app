using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    internal interface IDagsService
    {
        public void Add(Dag dag);

        public List<Dag> GetAll();

        public Dag? GetById(int id);

        public bool Update(Dag dag);

        public bool Delete(Dag dag);



    }
}
