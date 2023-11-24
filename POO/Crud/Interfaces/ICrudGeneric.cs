using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Interfaces
{
    internal interface ICrudGeneric<T>
    {
        public bool Delete(T t);
        public bool Salvar(T t);
        public List<T> GetItens();
        public T GetItemByID(int id);
        public bool Update(T t);


    }
}
