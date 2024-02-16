using Microsoft.EntityFrameworkCore;
using BolidIntegrServ.Models;

namespace BolidIntegrServ.Data;

public class OrionDbContext : DbContext
{
    public OrionDbContext(DbContextOptions<OrionDbContext> options) : base(options)
    {
    }

    // Определите здесь ваши сущности (таблицы)
    public DbSet<pList> pList { get; set; }
    public DbSet<pLogData> pLogData { get; set; }
}