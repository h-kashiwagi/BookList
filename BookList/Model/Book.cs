using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //[Key]を使うためモジュール
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Model
{
    public class Book
    {
        [Key] //プライマリーキー（主キー）※実質、nullはNG
        public int Id { get; set; }

        [Required] //nullはNG
        public string Name { get; set; } //Bookの名前
        public string Author { get; set; } //Bookの著者
        public string ISBN { get; set; }

    }
}
