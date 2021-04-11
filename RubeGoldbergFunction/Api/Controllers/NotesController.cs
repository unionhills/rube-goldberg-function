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
        private readonly INoteService _noteService;

        public NotesController(ILogger<NotesController> logger, INoteService noteService)
        {
            _logger = logger;
            _noteService = noteService;
        }

        [HttpGet]
        public IEnumerable<Note> Get()
        {
            ICollection<Note> notes = _noteService.GetNotes();

            return (notes);
        }
    }
}
