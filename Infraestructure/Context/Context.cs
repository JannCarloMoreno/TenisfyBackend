using Core.Domain.DTOs;
using Core.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infraestructure.Context
{


    public class Context : BaseContext
    {
        #region Constructors
        public Context(DbContextOptions options) : base(options)
        {
        }
        #endregion

        #region DbSets
        #endregion

        #region DbContext Overrides
        #endregion

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<Context>
        {
            public Context CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile(Directory.GetCurrentDirectory() + "/../Api/appsettings.json")
                    .Build();
                var builder = new DbContextOptionsBuilder<Context>();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                builder.UseSqlServer(connectionString);
                return new Context(builder.Options);
            }
        }
    }
}
