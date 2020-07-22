using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface ILoad<in TEntity> where TEntity:class
    {
        void Search(string search);
        void Init();
        void Details();
        void Details(TEntity item);
    }
}
