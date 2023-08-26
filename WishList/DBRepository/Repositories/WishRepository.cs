using DBRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Microsoft.EntityFrameworkCore;

namespace DBRepository.Repositories
{
    public class WishRepository : BaseRepository, IWishRepository
    {
        public WishRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory) { }

        public async Task<PageOfWishes<Wish>> GetWishes(int index, int pageSize)
        {
            var result = new PageOfWishes<Wish>() { CurrentPage = index, PageSize = pageSize };

            using (var context = ContextFactory.CreateDbContext(ConnectionString)) // 1
            {
                IQueryable<Wish> query = context.Wishes.AsQueryable();
                result.TotalPages = await query.CountAsync();
                query = query.Include(p => p.Description).Include(p => p.Image).OrderByDescending(p => p.Date).Skip(index * pageSize).Take(pageSize); // 2
                result.Wishes = await query.ToListAsync(); //3
            }

            return result;
        }
    }
}
