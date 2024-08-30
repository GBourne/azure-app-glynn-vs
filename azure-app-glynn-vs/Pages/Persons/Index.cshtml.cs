using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using azure_app_glynn_vs.Data;

namespace azure_app_glynn_vs.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly azure_app_glynn_vs.Data.AppDbContext _context;

        public IndexModel(azure_app_glynn_vs.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Persons { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Persons = await _context.Persons.ToListAsync();
        }
    }
}
