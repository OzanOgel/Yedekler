using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ZeytinYagliWebApp.Models
{
    public partial class OliveOilDBModel : DbContext
    {
        public OliveOilDBModel()
            : base("name=OliveOilDBModel")
        {

        }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
