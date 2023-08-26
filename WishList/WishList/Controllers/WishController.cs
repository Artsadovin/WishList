using DBRepository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WishList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WishController : Controller
    {
        IWishRepository _wishRepository;

        public WishController(IWishRepository wishRepository)
        {
            _wishRepository = wishRepository;
        }

        [Route("page")]
        [HttpGet]
        public async Task<PageOfWishes<Wish>> GetWishes(int pageIndex)
        {
            return await _wishRepository.GetWishes(pageIndex, 10);
        }
    }
}
