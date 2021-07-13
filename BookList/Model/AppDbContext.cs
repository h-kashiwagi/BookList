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
            //DbContentのコンストラクターの内容をbaseで継承
            //おそらくBookプロパティにBookのオブジェクトを格納している
        }
        //いくつかのモデルをデータベースに追加するBookモデルを追加する必要がある
        //エンティティとテーブルのマッピング
        //DbSet<エンティティ>型のパブリックプロパティ
        public DbSet<Book> Book {get;set;}

        
    }
}
