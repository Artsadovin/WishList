using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using Domain.Repositories;

namespace Infrastructure
{
    internal class WishRepository : IWishRepository
    {
        private readonly ApplicationContext _context;

        public WishRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void AddWish(Wish wish)
        {
            _context.Wishes.Add(wish);
        }

        public List<Wish> GetWishes()
        {
            return _context.Wishes.ToList();
        }
    }
}
