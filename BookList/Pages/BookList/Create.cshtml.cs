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
        private readonly AppDbContext _db; //AppDbContextを使用するためにusing BookList.Model;をする

        public CreateModel(AppDbContext db)
        {
            _db = db;
        }

        public Book Book { get; set; } //IEnumerable<Book>ではない

        public void OnGet()
        {
        }
    }
}
