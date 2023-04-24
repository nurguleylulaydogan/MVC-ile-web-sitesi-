using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Nurgül_Eylül_Aydoğan_201103046.DAL
{
    public partial class DatabaseModel : DbContext
    {
        public DatabaseModel()
            : base("name=DatabaseModel")
        {
        }

        public virtual DbSet<Anasayfa> Anasayfa { get; set; }
        public virtual DbSet<Cozumler> Cozumler { get; set; }
        public virtual DbSet<Kurumsal> Kurumsal { get; set; }
        public virtual DbSet<Projedetay> Projedetay { get; set; }
        public virtual DbSet<referanslar> referanslar { get; set; }
        public virtual DbSet<sitebilgi> sitebilgi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
