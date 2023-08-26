using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBRepository.Interfaces
{
    public interface IWishRepository
    {
        Task<PageOfWishes<Wish>> GetWishes(int index, int pageSize);
        //Task<Wish> GetWish(int wishId);
        //Task AddWish(Wish wish);
        //Task DeleteWish(int wishId);

    }
}
