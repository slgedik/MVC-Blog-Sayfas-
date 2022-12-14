using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class CategoryModel // sayfada gösterilcek alanlar icin değişken oluşturma
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public int BlogSayisi { get; set; }
    }
}