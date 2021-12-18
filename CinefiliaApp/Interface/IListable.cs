using System.Collections.Generic;
using System.Threading.Tasks;

namespace CinefiliaApp.Interface
{
    public interface IListable<T>
    {
        public  Task<List<T>> GetListAsync();
        public Task<T> GetAsync(int id);
    }
}
