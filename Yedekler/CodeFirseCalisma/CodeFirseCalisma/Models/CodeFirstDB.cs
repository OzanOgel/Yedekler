using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirseCalisma.Models
{
    public partial class CodeFirstDB : DbContext
    {
        public CodeFirstDB()
            : base("name=CodeFirstDB")
        {

        }
        public virtual DbSet<Kategoriler> Kategorilers { get; set; }
        public virtual DbSet<Tedarikciler> Tedarikcilers { get; set; }
        public virtual DbSet<Urunler> Urunsler { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
