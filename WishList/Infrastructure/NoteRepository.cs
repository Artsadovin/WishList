using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using Domain.Repositories;

namespace Infrastructure
{
    internal class NoteRepository : INoteRepository
    {
        private readonly ApplicationContext _context;

        public NoteRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void AddNote(Note note)
        {
            _context.Notes.Add(note);
        }

        public List<Note> GetNotes()
        {
            return _context.Notes.ToList();
        }
    }
}
