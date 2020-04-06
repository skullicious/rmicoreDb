using rmicore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Interface
{
    public interface IDataRepository
    {
       public List<Title> GetAllTitles();
    }
}
