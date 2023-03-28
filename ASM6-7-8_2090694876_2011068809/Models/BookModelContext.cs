using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ASM6_7_8_2090694876_2011068809.Models
{
    public partial class BookModelContext : DbContext
    {
        public BookModelContext()
            : base("name=BookModelContext")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
