using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibon.Api.Repository
{
    public interface IRepository
    {
        void Insert(int number, int result);
        int? Get(int number);
    }
}
