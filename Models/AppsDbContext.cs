using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;
using abkl_plt_procon.Models; // Ganti dengan namespace yang sesuai

public class AppsDbContext : DbContext
{
    public AppsDbContext(DbContextOptions<AppsDbContext> options) : base(options) { }

    public DbSet<TBL_M_MENU> TBL_M_MENU { get; set; }
}
