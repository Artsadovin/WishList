using Domain.Entity;
using WishList.DTO;

namespace WishList.Converters
{
    public class AddDtoNoteToNote
    {
        public static Note ConvertDtoToNote(AddNoteDto dto)
        {
            Note note = new Note();
            note.Created = DateTime.Now;
            note.Type = dto.Type;
            return note;
        }
    }
}
