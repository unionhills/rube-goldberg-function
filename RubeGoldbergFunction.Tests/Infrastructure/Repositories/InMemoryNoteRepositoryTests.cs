using System;
using Xunit;
using System.Text;
using System.Collections.Generic;

using RubeGoldbergFunction.Core.Entities;
using RubeGoldbergFunction.Infrastructure.Repositories;

namespace RubeGoldbergFunction.Tests.Infrastructure.Repositories
{
    public class NoteRepositoryTests
    {
        [Fact]
        public void ObjectCreationTest()
        {
            InMemoryNoteRepository noteRepo = new();

            Assert.NotNull(noteRepo);
        }

        [Fact]
        public void GetAllNotesTest()
        {
            InMemoryNoteRepository noteRepo = new();
            IList<Note> noteList = noteRepo.FindAll();

            Assert.NotNull(noteList);
            Assert.NotEmpty(noteList);
        }

        [Fact]
        public void CreateNewNoteTest()
        {
            InMemoryNoteRepository noteRepo = new();
            IList<Note> noteList = noteRepo.FindAll();

            Assert.NotNull(noteList);
            Assert.NotEmpty(noteList);
        }
    }
}
