using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using RubeGoldbergFunction.Core.Entities;
using RubeGoldbergFunction.Core.Services;

namespace RubeGoldbergFunction.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly ILogger<NotesController> _logger;
        private readonly NoteService _noteService;

        public NotesController(ILogger<NotesController> logger)
        {
            _logger = logger;
            _noteService = new();
        }

        [HttpGet]
        public IEnumerable<Note> Get()
        {
            ICollection<Note> notes = _noteService.GetNotes();

            return (notes);
        }
    }
}
