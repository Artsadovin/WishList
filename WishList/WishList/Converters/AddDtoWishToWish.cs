using Domain.Entity;
using WishList.DTO;

namespace WishList.Converters
{
    public class AddDtoWishToWish
    {
        public static Wish ConvertDtoToNote(AddWishDto dto)
        {
            Wish note = new Wish();
            note.Created = DateTime.Now;
            note.Type = dto.Type;
            return note;
        }
    }
}
