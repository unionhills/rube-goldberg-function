using System;
using Xunit;
using RubeGoldbergFunction.Core.Entities;

namespace RubeGoldbergFunction.Tests.Core.Entities
{
    public class NoteEntityTests
    {
        [Fact]
        public void ObjectCreationTest()
        {
            Note note = new();

            Assert.NotNull(note.Trace);
            Assert.Empty(note.Trace);
        }
    }
}
