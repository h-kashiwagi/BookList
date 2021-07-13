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
    public class IndexModel : PageModel�@//RazorPage��ǉ������Ƃ��Ɏ�����������Ă���
    {
        //�ˑ����̒������s���Ă��邩��C���X�^���X�𐶐�����K�v���Ȃ��H
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        
        public IEnumerable<Book> Books { get; set; }�@�@//List<Book>�Ƃ̈Ⴂ�́H

        //�������\�b�h�ɂ������ꍇ��OnGet()
        //Http Get�v���ɑΉ����郁�\�b�h
        //�߂�l��Task
        public async Task OnGetAsync() //���ۂ�public async Task OnGet�ɂ��Ă��Ⴂ�͂Ȃ��BOnGetAsync�͔񓯊��R�[�h���܂ޖ����K���ɉ߂��Ȃ�����Async�͏ȗ��\�B
        {
            Books = await _db.Book.ToListAsync();
        }
    }
}
