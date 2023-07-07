using Aula_12_Entity_Framework.Domain;
using Microsoft.EntityFrameworkCore;

namespace Aula_12_Entity_Framework
{
    public class DataContext : DbContext
    {
        public string DbPath { get; }

        public DataContext()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "TestEFQuarta.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Person> People { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}