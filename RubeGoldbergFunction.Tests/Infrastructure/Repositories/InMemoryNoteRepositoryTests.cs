using System;
using Xunit;
using System.Text;
using System.Collections.Generic;

using RubeGoldbergFunction.Core.Entities;
using RubeGoldbergFunction.Infrastructure.Repositories;
using RubeGoldbergFunction.Core.Utils;

namespace RubeGoldbergFunction.Tests.Infrastructure.Repositories
{
    public class InMemoryNoteRepositoryTests : IDisposable
    {
        InMemoryNoteRepository _noteRepo;

        public InMemoryNoteRepositoryTests()
        {
            _noteRepo = new();
        }

        public void Dispose()
        {
            _noteRepo.Dispose();
        }

        [Fact]
        public void ObjectCreationTest()
        {
            Assert.NotNull(_noteRepo);
        }

        [Fact]
        public void GetAllNotesTest()
        {
            ICollection<Note> noteList = _noteRepo.FindAll();

            Assert.NotNull(noteList);
            Assert.NotEmpty(noteList);
        }

        private Note AddNewRandomNote()
        {
            Note newNote = NoteUtils.BuildRandomNote();

            newNote = _noteRepo.Create(newNote);

            return (newNote);
        }

        [Fact]
        public void CreateNewNoteTest()
        {
            ICollection<Note> noteList = _noteRepo.FindAll();
            int recordCount = noteList.Count;

            Note newNote = AddNewRandomNote();
            noteList = _noteRepo.FindAll();

            Assert.Equal(noteList.Count, recordCount + 1);
            Assert.NotNull(newNote.Id);
            Assert.True(newNote.Id.Length > 0);
        }

        [Fact]
        public void FindNoteByIdTest()
        {
            Note newNote = AddNewRandomNote();
            Note foundNote = _noteRepo.FindById(newNote.Id);

            Assert.Equal(newNote.Id, foundNote.Id);
        }
    }
}
