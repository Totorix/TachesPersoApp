using EFDataAccessLibrary.Dal;
using EFDataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace TachesPerso.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly TacheContext _db;

        public IndexModel(ILogger<IndexModel> logger, TacheContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            LoadSampleData();

            var taches = _db.Taches//.Include(x => x.Actions)
                .ToList();

        }

        private void LoadSampleData()
        {
            if (_db.Actes.Count() == 0)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                string input = System.IO.File.ReadAllText("initDonnees.json");
                var taches = JsonSerializer.Deserialize<List<Tache>>(input, options);
                _db.AddRange(taches);
                _db.SaveChanges();
            }
        }
    }
}
