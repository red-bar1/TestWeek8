using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repositories
{
    public interface IRepository<T>
    {
        public T GetByNome(string nome);
        public T Add(T item);

    }
}
