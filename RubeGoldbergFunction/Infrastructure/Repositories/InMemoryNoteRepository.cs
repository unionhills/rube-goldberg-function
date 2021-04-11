using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RubeGoldbergFunction.Core.Entities;
using RubeGoldbergFunction.Core.Utils;

namespace RubeGoldbergFunction.Infrastructure.Repositories
{
    public class InMemoryNoteRepository : IDisposable
    {
        private IList<Note> _noteCollection;
        private int _itemId = 0;

        public InMemoryNoteRepository()
        {
            _noteCollection = new List<Note>();
            this.FillWithSampleData();
        }

        public void Dispose()
        {
            _noteCollection.Clear();
        }

        private String AllocateNextId()
        {
            return (_itemId++).ToString();
        }

        private void FillWithSampleData()
        {
            Note newNote = NoteUtils.BuildRandomNote();

            Create(newNote);
        }

        public ICollection<Note> FindAll()
        {
            return _noteCollection;
        }

        public Note FindById(String id)
        {
            Note note = _noteCollection.First(note => note.Id == id);

            return note;
        }

        public Note Create(Note newNote)
        {
            newNote.Id = AllocateNextId();

            newNote.CreatedAt = DateTime.Now;
            newNote.UpdatedAt = DateTime.Now;
            newNote.Trace.Add("New Note persisted to database");

            _noteCollection.Add(newNote);

            return newNote;
        }
    }
}
