using ems.Debugging;

namespace ems
{
    public class emsConsts
    {
        public const string LocalizationSourceName = "ems";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d628ed501c304061850edf462567109b";
    }
}
