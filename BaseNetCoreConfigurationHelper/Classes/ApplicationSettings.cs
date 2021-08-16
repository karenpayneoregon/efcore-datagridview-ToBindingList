using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNetCoreConfigurationHelper.Classes
{
    /// <summary>
    /// More to comes, base work done only
    /// </summary>
    public sealed class ApplicationSettings
    {
        /// <summary>
        /// Creates a thread safe instance of this class
        /// </summary>
        private static readonly Lazy<ApplicationSettings> Lazy = new(() => new ApplicationSettings());
        /// <summary>
        /// Access point to methods and properties
        /// </summary>
        public static ApplicationSettings Instance => Lazy.Value;
        /// <summary>
        /// Indicates if Entity Framework should use logging
        /// </summary>
        public bool UsingLogging { get; internal set; }
    }
}
