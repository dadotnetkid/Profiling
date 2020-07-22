using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface ITransaction<in TEntity> : ILoad<TEntity> where TEntity : class
    {
        void Save();
    }
}
