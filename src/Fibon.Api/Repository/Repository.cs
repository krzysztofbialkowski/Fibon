using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibon.Api.Repository
{
    public class Repository : IRepository
    {
        private Dictionary<int,int> storage = new Dictionary<int, int>();

        public void Insert(int number, int result)
        {
            storage[number] = result;
        }

        public int? Get(int number)
        {
            int result;

            if (storage.TryGetValue(number, out result))
            {
                return result;
            }
            return null;
        }
    }
}
