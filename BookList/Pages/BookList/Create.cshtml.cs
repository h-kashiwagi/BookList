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
        private readonly AppDbContext _db; //AppDbContext���g�p���邽�߂�using BookList.Model;������

        public CreateModel(AppDbContext db)
        {
            _db = db;
        }

        public Book Book { get; set; } //IEnumerable<Book>�ł͂Ȃ�

        public void OnGet()
        {
        }
    }
}
