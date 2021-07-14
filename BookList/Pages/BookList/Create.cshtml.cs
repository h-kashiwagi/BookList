using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _db; //AppDbContext‚ðŽg—p‚·‚é‚½‚ß‚Éusing BookList.Model;‚ð‚·‚é

        public CreateModel(AppDbContext db)
        {
            _db = db;
        }

        public Book Book { get; set; } //IEnumerable<Book>‚Å‚Í‚È‚¢

        public void OnGet()
        {
        }
    }
}
