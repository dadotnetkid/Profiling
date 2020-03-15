using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IUserControl<in TEntity>
    {
        void CreateUcControl(int Id);
        void CreateUcControl();
        void Details(TEntity item);
        void Details(int Id);
        void Details(int id, string tableName);
        void Search(string search);
    }
}
