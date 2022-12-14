using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>   //seed methoduyla veritabanına örnek veriler ekleme
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi= "Eglence"},
                new Category(){KategoriAdi= "Sanat"},
                new Category(){KategoriAdi= "Teknoloji"},
                new Category(){KategoriAdi= "Sağlık"},
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

      /*    List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){Baslik= "React kütüphanesi hakkında", Aciklama="react kütüphanesi hakkında", EklenmeTarihi= DateTime.Now.AddDays(-10), Anasayfa= true, Onay=true , İcerik= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Resim="1.jpg", CategoryId=3 },
                new Blog(){Baslik= "html hakkında", Aciklama="blablabla", EklenmeTarihi= DateTime.Now.AddDays(-20), Anasayfa= false, Onay=true , İcerik= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Resim="1.jpg", CategoryId=2 },
                new Blog(){Baslik= ".Net bilgileri", Aciklama="lorem ipsum", EklenmeTarihi= DateTime.Now.AddDays(-15), Anasayfa= true, Onay=true , İcerik= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Resim="1.jpg", CategoryId=1 },
                new Blog(){Baslik= "saglıklı yasam", Aciklama="saglıklı yasam hakkında", EklenmeTarihi= DateTime.Now.AddDays(-5), Anasayfa= false, Onay=false , İcerik= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Resim="2.jpg", CategoryId=1 },
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();  */
            base.Seed(context); // veri tabanına test verileri eklemeyi sağlar
        }
    }
}