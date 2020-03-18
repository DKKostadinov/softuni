
namespace Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Repository
    {
        private Dictionary<int, Person> data;
        private int counter;
        public Repository()
        {
            data = new Dictionary<int, Person>();
            counter = 0;
        }

        public int Count { get { return data.Count; } }

        public void Add(Person person)
        {
            data.Add(counter, person);
            counter++;
        }

        public Person Get(int id)
        {
            try
            {
                return data[id];
            }
            catch (Exception) { return null; }
        }

        public bool Update(int id, Person newPerson)
        {
            if(id >= 0 && id < data.Count)
            {
                data[id] = newPerson;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            if (id >= 0 && id < data.Count)
            {
                data.Remove(id);
                return true;
            }
            return false;
        }



    }
}
