using Movie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Movie.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company { 
                    Id = 1, 
                    Name = "Tech Solution", 
                    StreetAddress = "123 Tech St", 
                    City="Tech City", 
                    PostalCode="12121", 
                    State="IL", 
                    PhoneNumber="6669996666" 
                },
                new Company
                {
                    Id = 2,
                    Name = "Vivid Movies",
                    StreetAddress = "999 Vid St",
                    City = "Vid City",
                    PostalCode = "77777",
                    State = "IL",
                    PhoneNumber = "7779997777"
                }, new Company
                {
                    Id = 3,
                    Name = "Movie Club",
                    StreetAddress = "999 Main St",
                    City = "Lala Land",
                    PostalCode = "99999",
                    State = "IL",
                    PhoneNumber = "1112223333"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Interstellar",
                    Director = "Christopher Nolan",
                    Description = "Set in a future where a failing Earth puts humanity on the brink of extinction, it sees an intrepid team of NASA scientists, engineers and pilots attempt to find a new habitable planet, via interstellar travel.\r\n\r\nVery cool movie. ",
                    ReleaseYear = "2014",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Guardians of the Galaxy",
                    Director = "James Gunn",
                    Description = "An action-packed, epic space adventure, Marvel's \"Guardians of the Galaxy,\" expands the Marvel Cinematic Universe into the cosmos, where brash adventurer Peter Quill finds himself the object of an unrelenting bounty hunt after stealing a mysterious orb coveted by Ronan, a powerful villain with ambitions that threaten the entire universe. To evade the ever-persistent Ronan, Quill is forced into an uneasy truce with a quartet of disparate misfits--Rocket, a gun-toting raccoon; Groot, a tree-like humanoid; the deadly and enigmatic Gamora; and the revenge-driven Drax the Destroyer. But when Quill discovers the true power of the orb and the menace it poses to the cosmos, he must do his best to rally his ragtag rivals for a last, desperate stand--with the galaxy's fate in the balance.\r\n\r\nVery cool movie. ",
                    ReleaseYear = "2014",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Prisoners",
                    Director = "Denis Villeneuve",
                    Description = "When Keller Dover's daughter and her friend go missing, he takes matters into his own hands as the police pursue multiple leads and the pressure mounts. When Keller Dover's daughter and her friend go missing, he takes matters into his own hands as the police pursue multiple leads and the pressure mounts.\r\n\r\nVery cool movie. ",
                    ReleaseYear = "2013",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Star Wars: The Rise of Skywalker",
                    Director = "J. J. Abrams",
                    Description = "Set one year after The Last Jedi, The Rise of Skywalker follows Rey, Finn, and Poe Dameron as they lead the Resistance's final stand against Supreme Leader Kylo Ren and the First Order, who are aided by the return of the Galactic Emperor, Palpatine.\r\n\r\nVery cool movie. ",
                    ReleaseYear = "2019",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Midsommar",
                    Director = "Ari Aster",
                    Description = "MidSommar shows us a group of friends going on what seems like an idyllic trip to the Midsummer festival in a village in Northern Sweden. But that quickly turns into a harrowing display of Pagan rituals and ceremonies.\r\n\r\nVery cool movie. ",
                    ReleaseYear = "2019",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "Aftersun",
                    Director = "Charlotte Wells",
                    Description = "Aftersun is a 2022 coming-of-age drama film written and directed by Charlotte Wells in her feature directorial debut. Starring Paul Mescal, Frankie Corio, and Celia Rowlson-Hall, the film follows an 11-year-old Scottish girl on holiday with her father at a Turkish resort on the eve of his 31st birthday..\r\n\r\nVery cool movie. ",
                    ReleaseYear = "2022",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );
        }
    }
}
