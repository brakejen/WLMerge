using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WLMerge
{
    static class Program
    {
        public enum History
        {
            FirstRun,
            NewVersion,
            NewBuild,
            NoChange
        }

        public const string AppName = "WLMerge";

        private const string VersionFile = AppName + ".Version";

        private static string GetVersionNumberShort(string version)
        {
            return version.Substring(0, version.LastIndexOf('.'));
        }
          
        private static string GetBuildNumber(string version)
        {
            return version.Substring(version.LastIndexOf('.') + 1);
        }

        /// <summary>
        ///     Gets the assembly company.
        /// </summary>
        public static string AssemblyCompany
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                return attributes.Length == 0 ? string.Empty : ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        /// <summary>
        ///     Gets the assembly compile time.
        /// </summary>
        public static string AssemblyCompileTime => 
            PeHeaderReader.GetAssemblyHeader(Assembly.GetExecutingAssembly()).TimeStamp.ToString(Thread.CurrentThread.CurrentCulture);


        /// <summary>
        ///     Gets the assembly copyright.
        /// </summary>
        public static string AssemblyCopyright
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                return attributes.Length == 0 ? string.Empty : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        /// <summary>
        ///     Gets the assembly description.
        /// </summary>
        public static string AssemblyDescription
        {
            get
            {
                var attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                return attributes.Length == 0
                           ? string.Empty
                           : ((AssemblyDescriptionAttribute)attributes[0]).Description.Replace(
                               "\n",
                               Environment.NewLine);
            }
        }

        /// <summary>
        ///     Gets the assembly dot net version.
        /// </summary>
        public static string AssemblyDotNetVersion => Assembly.GetExecutingAssembly().ImageRuntimeVersion.Trim('v');

        public static string AssemblyGuid
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), true);
                return attributes.Length == 0 ? string.Empty : ((GuidAttribute)attributes[0]).Value;
            }
        }

        /// <summary>
        ///     Gets the assembly path.
        /// </summary>
        public static string AssemblyPath => Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        /// <summary>
        ///     Gets the assembly product.
        /// </summary>
        public static string AssemblyProduct
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? string.Empty : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        /// <summary>
        ///     Gets the assembly title.
        /// </summary>
        public static string AssemblyTitle
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    var titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != string.Empty)
                    {
                        return titleAttribute.Title;
                    }
                }

                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        /// <summary>
        ///     Gets the assembly version.
        /// </summary>
        public static string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public static string AssemblyVersionShort => GetVersionNumberShort(AssemblyVersion);

        public static string AssemblyVersionBuild => GetBuildNumber(AssemblyVersion);


        /// <summary>
        ///     Gets the configuration directory.
        /// </summary>
        public static string ConfigDir
        {
            get
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
                var path = Path.GetDirectoryName(config.FilePath);

                return path;
            }
        }

        /// <summary>
        ///     Gets the config file.
        /// </summary>
        public static string ConfigFile
        {
            get
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
                return config.FilePath;
            }
        }

        public static History VersionHistory
        {
            get
            {
                var versionFile = Path.Combine(AssemblyPath, VersionFile);
                History versionHistory;

                if (File.Exists(versionFile))
                {
                    var lastVersionUsed = File.ReadAllText(versionFile).Trim();

                    if (lastVersionUsed == AssemblyVersion)
                    {
                        return History.NoChange;
                    }

                    if (GetVersionNumberShort(lastVersionUsed) != AssemblyVersionShort)
                    {
                        versionHistory = History.NewVersion;
                    }
                    else
                    {
                        versionHistory = History.NewBuild;
                    }
                }
                else
                {
                    versionHistory = History.FirstRun;
                }

                File.WriteAllText(Path.Combine(AssemblyPath, VersionFile), AssemblyVersion);
                return versionHistory;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
