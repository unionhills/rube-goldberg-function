using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RubeGoldbergFunction.Infrastructure.Repositories;
using RubeGoldbergFunction.Core.Entities;

namespace RubeGoldbergFunction.Infrastructure.Repositories
{
    public class InMemoryNoteRepository
    {
        private List<Note> _noteCollection;

        public InMemoryNoteRepository()
        {
            _noteCollection = new();
            this.fillWithSampleData();
        }


        private void fillWithSampleData()
        {
            _noteCollection.Add(new Note());
        }

        public IList<Note> FindAll()
        {
            return _noteCollection;
        }
    }
}
