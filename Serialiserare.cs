using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DAL;

namespace BL
{
    internal class Serialiserare<T>
    {

        public string Path { get; set; }
        public Serialiserare(string path)
        {
            this.Path = path;
        }

        public void Serialisera(T t)
        {
            XmlSerializer serie = new XmlSerializer(typeof(T));

            using (FileStream ström = new FileStream(Path, FileMode.Create, FileAccess.Write))
            {
                serie.Serialize(ström, t);
            }
        }

        public T DeSerialisera()
        {
            XmlSerializer serie = new XmlSerializer(typeof(T));

            using (FileStream ström = new FileStream(Path, FileMode.Open, FileAccess.Read))
            {
                return (T)serie.Deserialize(ström);
            }
        }
    }
}
