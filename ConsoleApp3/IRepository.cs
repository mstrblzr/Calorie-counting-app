using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public interface IRepository<T>
    {
        public void Add(T t);

        public List<T> GetAll();

        public T? GetById(int id);

        public bool Update(T t);

        public bool Delete(T t);


    }
}
