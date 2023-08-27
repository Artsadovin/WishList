using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface INoteRepository
    {
        void AddNote(Note note);
        List<Note> GetNotes();  
    }
}
