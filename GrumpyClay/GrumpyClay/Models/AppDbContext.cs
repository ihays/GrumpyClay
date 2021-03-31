using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrumpyClay.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Sculpture> Sculptures { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Original" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cartoon" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Video Game" });

            //seed pies

            modelBuilder.Entity<Sculpture>().HasData(new Sculpture
            {
                SculptureId = 1,
                Name = "Handmade Sackboy",
                Price = 65.00M,
                ShortDescription = "Sackboy from Little Big Planet",
                LongDescription = "I created the sculpture by shaping clay, then I copied the clay sculpture into plastic. Next, I hand painted the plastic copy and added a protective coating to keep it looking nice. This sculpture was built to last!",
                IsSculptureOfTheWeek = false,
                InStock = true,
                CategoryId = 3,
                ImageUrl = "https://i.etsystatic.com/27116147/r/il/39622e/2872265535/il_794xN.2872265535_r2ij.jpg",
                ImageThumbnailUrl = "https://i.etsystatic.com/27116147/r/il/39622e/2872265535/il_794xN.2872265535_r2ij.jpg"
            });

            modelBuilder.Entity<Sculpture>().HasData(new Sculpture
            {
                SculptureId = 2,
                Name = "Poison Apple",
                Price = 15.00M,
                ShortDescription = "Apple inspired by Snow White and the Seven Dwarves",
                LongDescription = "Apple inspired by Snow White and the Seven Dwarves. Don’t eat it! ;)",
                IsSculptureOfTheWeek = false,
                InStock = true,
                CategoryId = 2,
                ImageUrl = "https://i.etsystatic.com/27116147/r/il/08bb82/2864918839/il_794xN.2864918839_dxl2.jpg",
                ImageThumbnailUrl = "https://i.etsystatic.com/27116147/r/il/08bb82/2864918839/il_794xN.2864918839_dxl2.jpg"
            });

            modelBuilder.Entity<Sculpture>().HasData(new Sculpture
            {
                SculptureId = 3,
                Name = "Tentacle Holding a Rose",
                Price = 30.00M,
                ShortDescription = "Original tentacle holding a rose",
                LongDescription = "Made from high quality resin and hand painted.",
                IsSculptureOfTheWeek = true,
                InStock = true,
                CategoryId = 1,
                ImageUrl = "https://i.etsystatic.com/27116147/r/il/27a5b5/2928270607/il_794xN.2928270607_5jlb.jpg",
                ImageThumbnailUrl = "https://i.etsystatic.com/27116147/r/il/27a5b5/2928270607/il_794xN.2928270607_5jlb.jpg"
            });
        }
    }
}
