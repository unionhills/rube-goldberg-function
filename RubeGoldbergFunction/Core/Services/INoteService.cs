using System;
using System.Collections.Generic;

using RubeGoldbergFunction.Core.Entities;

namespace RubeGoldbergFunction.Core.Services
{
    public interface INoteService
    {
        public ICollection<Note> GetNotes();
        public Note CreateNote(Note newNote);
        public Note GetNote(String id);
    }

}
