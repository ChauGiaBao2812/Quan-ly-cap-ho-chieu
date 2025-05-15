using Microsoft.EntityFrameworkCore;
using QLHoChieu.Models;

namespace QLHoChieu.Data
{
    public class PassportDbContext : DbContext
    {
        public PassportDbContext(DbContextOptions<PassportDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<ResidentData> ResidentDatas { get; set; } = null!;
        public DbSet<PassportData> PassportDatas { get; set; } = null!;
        public DbSet<XuLy> XuLys { get; set; } = null!;
        public DbSet<LuuTru> LuuTrus { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Enforce unique constraint on FormID in LuuTru
            modelBuilder.Entity<LuuTru>()
                .HasIndex(l => l.FormID)
                .IsUnique();

            // PassportData -> ResidentData (FK: CCCD)
            modelBuilder.Entity<PassportData>()
                .HasOne(p => p.ResidentData)
                .WithMany()
                .HasForeignKey(p => p.CCCD)
                .OnDelete(DeleteBehavior.Restrict);

            // XuLy -> PassportData (FK: FormID)
            modelBuilder.Entity<XuLy>()
                .HasOne(x => x.PassportData)
                .WithMany()
                .HasForeignKey(x => x.FormID)
                .OnDelete(DeleteBehavior.Cascade);

            // XuLy -> User (FK: UserID)
            modelBuilder.Entity<XuLy>()
                .HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            // LuuTru -> User (FK: UserID)
            modelBuilder.Entity<LuuTru>()
                .HasOne(l => l.User)
                .WithMany()
                .HasForeignKey(l => l.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            // LuuTru -> PassportData (FK: FormID)
            modelBuilder.Entity<LuuTru>()
                .HasOne(l => l.PassportData)
                .WithMany()
                .HasForeignKey(l => l.FormID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
