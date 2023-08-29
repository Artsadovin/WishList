using Domain;
using Domain.Entity;
using WishList.DTO;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using WishList.Converters;

namespace WishList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WishController : Controller
    {
        private readonly IWishRepository _wishRepository;
        private readonly IUnitOfWork _unitOfWork;

        public WishController(IWishRepository wishRepository, IUnitOfWork unitOfWork)
        {
            _wishRepository = wishRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "GetWishes")]
        public IEnumerable<Wish> GetWishes()
        {
            return _wishRepository.GetWishes();
        }

        [HttpPost(Name = "AddWish")]
        public IActionResult SaveWish(AddWishDto wishDto)
        {
            Wish wish = AddDtoWishToWish.ConvertDtoToWish(wishDto);
            _wishRepository.AddWish(wish);
            _unitOfWork.Commit();

            return new OkResult();
        }
    }
}
