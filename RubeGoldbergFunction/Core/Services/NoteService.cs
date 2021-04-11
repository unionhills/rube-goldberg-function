using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RubeGoldbergFunction.Core.Entities;
using RubeGoldbergFunction.Infrastructure.Repositories;

namespace RubeGoldbergFunction.Core.Services
{
    public class NoteService
    {
        private readonly InMemoryNoteRepository noteRepo;

        public NoteService()
        {
            noteRepo = new();
        }

        public ICollection<Note> GetNotes()
        {
            return noteRepo.FindAll();
        }

        public Note CreateNote(Note newNote)
        {
            Note createdNote = noteRepo.Create(newNote);

            return createdNote;
        }

        public Note GetNote(String id)
        {
            return noteRepo.FindById(id);
        }
    }

}
