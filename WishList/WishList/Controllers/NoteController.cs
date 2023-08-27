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
    public class NoteController : Controller
    {
        private readonly INoteRepository _noteRepository;
        private readonly IUnitOfWork _unitOfWork;

        public NoteController(INoteRepository noteRepository, IUnitOfWork unitOfWork)
        {
            _noteRepository = noteRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "GetNotes")]
        public IEnumerable<Note> Get()
        {
            return _noteRepository.GetNotes();
        }

        [HttpPost(Name = "AddNote")]
        public IActionResult SaveNote(AddNoteDto noteDto)
        {
            Note note = AddDtoNoteToNote.ConvertDtoToNote(noteDto);
            _noteRepository.AddNote(note);
            _unitOfWork.Commit();

            return new OkResult();
        }
    }
}
