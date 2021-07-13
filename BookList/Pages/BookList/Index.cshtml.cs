using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookList.Pages.BookList
{
    public class IndexModel : PageModel　//RazorPageを追加したときに自動生成されている
    {
        //依存性の注入を行っているからインスタンスを生成する必要がない？
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        
        public IEnumerable<Book> Books { get; set; }　　//List<Book>との違いは？

        //同期メソッドにしたい場合はOnGet()
        //Http Get要求に対応するメソッド
        //戻り値はTask
        public async Task OnGetAsync() //実際にpublic async Task OnGetにしても違いはない。OnGetAsyncは非同期コードを含む命名規則に過ぎないためAsyncは省略可能。
        {
            Books = await _db.Book.ToListAsync();
        }
    }
}
