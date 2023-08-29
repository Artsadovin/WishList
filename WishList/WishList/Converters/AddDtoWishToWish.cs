using Domain.Entity;
using WishList.DTO;

namespace WishList.Converters
{
    public class AddDtoWishToWish
    {
        public static Wish ConvertDtoToWish(AddWishDto dto)
        {
            Wish wish = new Wish();
            wish.Type = dto.Type;
            return wish;
        }
    }
}
