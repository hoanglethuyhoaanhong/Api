using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace MyWebAPI.Data
{
    public class MyDBContext : DbContext
    {

        //public class BloggingContextFactory : IDesignTimeDbContextFactory<DbContext>
        //{
        //    public DbContext CreateDbContext(string[] args)
        //    {
        //        var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
        //        optionsBuilder.UseSqlServer("Data Source=HOANGLETHUYHOA\\SQLEXPRESS");

        //        return new DbContext(optionsBuilder.Options);
        //    }
        //}
        public MyDBContext(DbContextOptions options)
       : base(options)
        { }
        #region DbSet
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<ThanhTuu> ThanhTuus { get; set; }
        public DbSet<CHITIETTHANHTUU> CHITIETTHANHTUUs { get; set; }    
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ThanhTuu>(e =>
            {
                e.ToTable("ThanhTuu");
                e.HasKey(tt => tt.MA_THANHTUU);

            });

            modelBuilder.Entity<CHITIETTHANHTUU>(entity =>
            {
                entity.ToTable("CHITIETTHANHTUU");
                entity.HasKey(e => new { e.MA_THANHTUU, e.MA_USER });

                entity.HasOne(e => e.ThanhTuu)
                .WithMany(e => e.CHITIETTHANHTUUs)
                .HasForeignKey(e => e.MA_THANHTUU)
                .HasConstraintName("FK_ChiTietTT_ThanhTuu");

                entity.HasOne(e => e.NguoiDung)
                .WithMany(e => e.CHITIETTHANHTUUs)
                .HasForeignKey(e => e.MA_USER)
                .HasConstraintName("FK_ChiTietTT_NguoiDung");
            });

            



        }

    }
}
