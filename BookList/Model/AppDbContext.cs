using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Model
{
    public class AppDbContext : DbContext
    {
        //コンストラクター
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //いくつかのモデルをデータベースに追加するBookモデルを追加する必要がある
        public DbSet<Book> Book {get;set;}

    }
}
