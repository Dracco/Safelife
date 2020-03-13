using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace BD
{
    public class MainContextFactory : IDesignTimeDbContextFactory<MainContext>, IDisposable
    {
        public static IConfigurationRoot configuration { get; private set; }

        public MainContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MainContext>();

            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var configurationBuilder = new ConfigurationBuilder();
            //if (!environmentName.ToLower().Equals("prod"))
            //{
            //    configurationBuilder.AddJsonFile($"appsettings.{environmentName}.json", true, true);
            //}
            //else
            //{
            //    configurationBuilder.AddJsonFile($"appsettings.json", true, true);
            //}

            configuration = configurationBuilder.Build();
            string conexao = "Server=dbsafelife.cob5rjpvi6jc.us-east-2.rds.amazonaws.com;Database=dbsafelife;User ID=root;Password=Emrsn070482;";// configuration["Connection"];
            builder.UseMySQL(conexao);
            return new MainContext(builder.Options);
        }

        public void Dispose()
        {

        }
    }

}
