using System;
using System.Collections.Generic;
using System.Text;
using Interview.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Interview.Infrastructure
{
    public class DataContextFactory : IDesignTimeDbContextFactory<AppDBContext>
    {

        public AppDBContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppDBContext>();
            builder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Data\\Study project\\MVC\\Interview\\Interview\\Interview.Infrastructure\\App_Data\\Interviewdatabase.mdf\";Integrated Security=True");
            return new AppDBContext(builder.Options);
        }
    }
}
