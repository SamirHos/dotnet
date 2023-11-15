using Microsoft.EntityFrameworkCore;

namespace WebApiProvaFinaleBSamir.DataSource
{
    public class LogContext: DbContext
    {
        public LogContext() { }
        public LogContext(DbContextOptions<LogContext> options) : base(options) { }

    }
}
