using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PresentationLayer
{
    public class MaträttsRepo: IRepository<Maträtt>
    {
        private List<Maträtt> allamaträtter;
        public MaträttsRepo()
        {
            allamaträtter = new List<Maträtt>();
        }

        public void Add(Maträtt maträtt)
        {
            allamaträtter.Add(maträtt);
        }

        public List<Maträtt> GetAll()
        {
            return allamaträtter;
        }

        public Maträtt? GetById (int id)
        {
            foreach(Maträtt m in allamaträtter)
            {
                if(m.Id == id)
                {
                    return m;
                }
            }
            return null;
        }

        public bool Update(Maträtt uppdateradMaträtt)
        {
            for (int i = 0; i< allamaträtter.Count; i++)
            {
                if(allamaträtter[i].Id == uppdateradMaträtt.Id)
                {
                    allamaträtter[i] = uppdateradMaträtt;
                    return true;
                }
            }
            return false;
        }

        public bool Delete(Maträtt maträtt)
        {
            for(int i = 0; i< allamaträtter.Count; i++)
            {
                if (allamaträtter[i].Id == maträtt.Id)
                {
                    allamaträtter.RemoveAt(i);
                    return true;
                }
            }
            return false; 
        }

        public List<Maträtt> KalÖver500()//om jag bara vill visa vad som finns i listan
        {
            List<Maträtt> MatOver500 = new List<Maträtt>();
            foreach(Maträtt m in allamaträtter)
            {
                if (m.Kalorier > 499)
                {
                    MatOver500.Add(m);
                }
            }
            return MatOver500;
        }
        public List<Maträtt> Kal1Över500()//om jag vill ändra saker i listan
        {
            List<Maträtt> MatOver500 = new List<Maträtt>();
            for(int i =0; i<allamaträtter.Count; i++)
            {
                if (allamaträtter[i].Kalorier > 499)
                {
                    MatOver500.Add(allamaträtter[i]);
                }
            }
            return MatOver500;
        }
    }

    

}
