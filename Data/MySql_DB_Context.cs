using Film_HF.Modell;
using Microsoft.EntityFrameworkCore;

namespace Film_HF.Data {
    public class MySql_DB_Context :DbContext {
        public MySql_DB_Context(DbContextOptions<MySql_DB_Context> options) : base(options) { }
        public DbSet<Film> Film { get; set; } = default;
    }
}
