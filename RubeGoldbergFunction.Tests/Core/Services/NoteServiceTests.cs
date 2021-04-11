using System;
using Xunit;
using System.Text;
using System.Collections.Generic;

using RubeGoldbergFunction.Core.Entities;
using RubeGoldbergFunction.Core.Services;
using RubeGoldbergFunction.Core.Utils;
using RubeGoldbergFunction.Infrastructure.Repositories;

namespace RubeGoldbergFunction.Tests.Core.Services
{
    public class NoteServiceTests
    {
        NoteService _noteService;

        public NoteServiceTests()
        {
            _noteService = new(new InMemoryNoteRepository());
        }

        [Fact]
        public void ObjectCreationTest()
        {
            Assert.NotNull(_noteService);
        }

        [Fact]
        public void GetAllNotesTest()
        {
            ICollection<Note> notes = _noteService.GetNotes();

            Assert.NotNull(notes);
            Assert.NotEmpty(notes);
        }

        private Note AddNewRandomNote()
        {
            Note newNote = NoteUtils.BuildRandomNote();

            newNote = _noteService.CreateNote(newNote);

            return (newNote);
        }

        [Fact]
        public void CreateNewNoteTest()
        {
            ICollection<Note> notes = _noteService.GetNotes();
            int recordCount = notes.Count;

            Note newNote = AddNewRandomNote();
            notes = _noteService.GetNotes();

            Assert.Equal(notes.Count, recordCount + 1);
            Assert.NotNull(newNote.Id);
            Assert.True(newNote.Id.Length > 0);
        }

        [Fact]
        public void GetNoteTest()
        {
            Note newNote = AddNewRandomNote();
            Note foundNote = _noteService.GetNote(newNote.Id);

            Assert.Equal(newNote.Id, foundNote.Id);
        }
    }
}
