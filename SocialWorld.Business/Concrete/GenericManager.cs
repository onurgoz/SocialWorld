using SocialWorld.Business.Interfaces;
using SocialWorld.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialWorld.Business.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class, new()
    {
        private readonly IGenericDal<T> _genericDal;

        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }
        public async Task AddAsync(T entity)
        {
            await _genericDal.AddAsync(entity);
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await _genericDal.FindByIdAsync(id);

        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _genericDal.GetAllAsync();
        }

        public async Task RemoveAsync(T entity)
        {
            await _genericDal.RemoveAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await _genericDal.UpdateAsync(entity);
        }
    }
}
