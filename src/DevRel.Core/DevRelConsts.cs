using DevRel.Debugging;

namespace DevRel
{
    public class DevRelConsts
    {
        public const string LocalizationSourceName = "DevRel";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "0eb20fbe0a9e4bd690d4b035b3ba6e75";
    }
}
