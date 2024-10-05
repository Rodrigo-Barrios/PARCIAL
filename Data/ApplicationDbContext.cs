using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PARCIAL.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<PARCIAL.Models.Remesa> DataRemesa { get; set; }
    public DbSet<PARCIAL.Models.ListadoRemesas> DataListadoRemesas { get; set; }



}