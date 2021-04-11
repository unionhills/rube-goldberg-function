using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RubeGoldbergFunction.Core.Entities;
using RubeGoldbergFunction.Infrastructure.Repositories;

namespace RubeGoldbergFunction.Core.Services
{
    public class NoteService : INoteService
    {
        private readonly IRepository<Note> _noteRepo;

        public NoteService(IRepository<Note> noteRepo)
        {
            _noteRepo = noteRepo;
        }

        public ICollection<Note> GetNotes()
        {
            return _noteRepo.FindAll();
        }

        public Note CreateNote(Note newNote)
        {
            Note createdNote = _noteRepo.Create(newNote);

            return createdNote;
        }

        public Note GetNote(String id)
        {
            return _noteRepo.FindById(id);
        }
    }

}
