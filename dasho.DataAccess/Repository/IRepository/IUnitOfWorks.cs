using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dasho.DataAccess.Repository.IRepository
{
    public interface IUnitOfWorks 
    {
        ICategoryRepository Category { get;}
        IProductRepository Product { get;}

        void Save();
    }
}
