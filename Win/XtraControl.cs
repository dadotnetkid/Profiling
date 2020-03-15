using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using Models;

namespace Win
{
    public class XtraControl<TEntity> : XtraUserControl, IUserControl<TEntity>
    {
        public void CreateUcControl(int Id)
        {
            throw new NotImplementedException();
        }

        public void CreateUcControl()
        {
            throw new NotImplementedException();
        }

        public void Details(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Details(int Id)
        {
            throw new NotImplementedException();
        }

        public void Details(int id, string tableName)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}
