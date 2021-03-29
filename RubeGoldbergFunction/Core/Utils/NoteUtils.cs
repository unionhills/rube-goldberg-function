using RubeGoldbergFunction.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RubeGoldbergFunction.Core.Utils
{
    public class NoteUtils
    {
        public static Note buildRandomNote()
        {
            Note newNote = new();

            newNote.Subject = "Subject";
            newNote.Body = "Body";
            newNote.CorrelationId = Guid.NewGuid().ToString();

            return newNote;
        }
    }
}
