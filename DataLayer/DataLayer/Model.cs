namespace DataLayer.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Data")
        {
        }

        public virtual DbSet<WorkerInfo> WorkerInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkerInfo>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
