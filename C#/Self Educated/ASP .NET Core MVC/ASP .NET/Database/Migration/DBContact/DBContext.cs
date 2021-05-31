using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3._Entity_Framework_Core_and_ADO_.NET.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace _3._Entity_Framework_Core_and_ADO_.NET.Models.DBContact
{
    /// <summary>
    /// Cách 2: Config DBContext
    /// </summary>
    public class DBContext : DbContext
    {
        private DbSet<Category> categories;
        private DbSet<Post> posts;

        public DbSet<Category> Categories { get => categories; set => categories = value; }
        public DbSet<Post> Posts { get => posts; set => posts = value; }

        //Ghi đè phương thức OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Config Key for Post
            //set key for Post
            modelBuilder.Entity<Post>().HasKey(e => e.PostID);

            //set key if Identity ID with Core v2.1 under
            /*modelBuilder.Entity<Post>()
                .Property(e => e.PostID).UseSqlServerIdentityColumn();*/

            //Set key tự động tăng theo cách khác v3.1 
            modelBuilder.Entity<Post>(b =>
            {
                b.HasKey(e => e.PostID);
                b.Property(e => e.PostID).ValueGeneratedOnAdd();
            });

            //Config Key for Categories
            modelBuilder.Entity<Category>().HasKey(e => e.ID);

            //Config relationship
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Posts)
                .WithOne(e => e.Category);

            //Config default for ViewCount = 0
            modelBuilder.Entity<Post>()
                .Property(e => e.ViewCount).HasDefaultValue(0);


            //Cách 4: Use Data SEEDING
            //for category
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategorieName = "Health Care",
                ID = 6
            });
            //for post <error>
            modelBuilder.Entity<Post>().HasData(new Post()
            {
                PostID = 1,
                PostTitle = "Beijing's office that oversees matters in Hong Kong",
                PostContent = "Beijing's Hong Kong office slams intimidation of judge in tycoon Jimmy Lai's case",
                PostDescription = "A representative for the Hong Kong and Macau Affairs Office (HKMAO) said the presiding judge had received threatening phone calls, " +
                                  "which the office said would not be tolerated.",
                ViewCount = 0,
                CateID = 1,
            });

        }


        //Ghi đè phương thức OnConfiguring để set Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("" +
                                        "Data Source = ZEROWL;" +
                                        "Initial Catalog = DemoASP;" +
                                        "User ID = sa;" +
                                        "Password= sa;");
            //Cách 3: Config connect db with appsettings.json

            //Important: Using Migration for CRUD with console command/ power shell/ Model Code First with Migration
            /*  1. Install EntityFrameworkCore, EntityFrameWork,
                    EntityFrameworkCore.SqlServer, EntityFrameworkCore.Tools libraries
                2. Open Package Manager Console + run command:
                - enable-migrations
                - add-migration <initial Name>   /Same Commit Github/  
                /Wait Until Build Success/ /add-migration initial - ContextName/ with more than 1 Context
                - update-database
             */
        }
    }
}
