using System;
using System.IO;
using BaseNetCoreConfigurationHelper.Classes;
using Microsoft.Extensions.Configuration;
using Environment = BaseNetCoreConfigurationHelper.Classes.Environment;

namespace BaseNetCoreConfigurationHelper
{
    public class Helper
    {

        /// <summary>
        /// Configuration file name to read from.
        /// </summary>
        public static string ConfigurationFileName { get; set; } = "appsettings.json";


        /// <summary>
        /// Current environment this application will run under
        /// </summary>
        public static string Environment
        {
            get
            {
                var config = InitMainConfiguration();
                return config.GetSection("Environment").Get<Environment>().Name;

            }
        }
        /// <summary>
        /// Connection string for application database stored in appsettings.json
        /// Another option would be to have the full connection string in the json file.
        /// </summary>
        /// <returns></returns>
        public static string ConnectionString()
        {

            InitMainConfiguration();
            var applicationSettings = InitOptions<DatabaseSettings>("database");

            var connectionString =
                $"Data Source={applicationSettings.DatabaseServer};" +
                $"Initial Catalog={applicationSettings.Catalog};" +
                "Integrated Security=True";

            return connectionString;
        }
        /// <summary>
        /// Determine if EF logging should be used
        /// </summary>
        /// <returns></returns>
        public static bool UseLogging()
        {

            InitMainConfiguration();

            var applicationSettings = InitOptions<ApplicationSettings>("database");

            return applicationSettings.UsingLogging;

        }
        /// <summary>
        /// Get connection string based on environment
        /// </summary>
        public static string GetConnectionString()
        {
            return InitMainConfiguration().GetConnectionString(InitOptions<Environment>("Environment").Production ?
                    "ProductionConnection" :
                    "DevelopmentConnection");
        }

        private static void LoadDevelopmentConnectionString()
        {
            throw new NotImplementedException();
        }

        private static void LoadProductionConnectionString()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initialize ConfigurationBuilder for appsettings
        /// </summary>
        /// <returns>IConfigurationRoot</returns>
        private static IConfigurationRoot InitMainConfiguration()
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(ConfigurationFileName);

            return builder.Build();

        }
        
        /// <summary>
        /// Generic method to read a section from the json configuration file.
        /// </summary>
        /// <typeparam name="T">Class type</typeparam>
        /// <param name="section">Section to read</param>
        /// <returns>Instance of T</returns>
        public static T InitOptions<T>(string section) where T : new()
        {
            var config = InitMainConfiguration();
            return config.GetSection(section).Get<T>();
        }
    }
}
