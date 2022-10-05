using Assignment.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Assignment;

internal class KanbanContextFactory : IDesignTimeDbContextFactory<KanbanContext>
{
    public KanbanContext CreateDbContext(string[] args)
    {

        string _conStr = @"
            Server=localhost,1433;
            Database=msdb;
            User Id=SA;
            Password=<YourStrong@Passw0rd>;";

        var optionsBuilder = new DbContextOptionsBuilder<KanbanContext>();
        optionsBuilder.UseSqlServer(_conStr);

        return new KanbanContext(optionsBuilder.Options);
    }
}