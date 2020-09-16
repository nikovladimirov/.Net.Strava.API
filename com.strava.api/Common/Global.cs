using System;

namespace com.strava.api.Common
{
    public static class Global
    {
        public static string Code { get; set; }

        public static string Token { get; set; }

        public static string ExpiresIn { get; set; }

        public static DateTime ExpiresAt { get; set; }

        public static string RefreshToken { get; set; }

        public static void SaveValues()
        {
            using (IniFile iniFile = new IniFile(System.IO.Directory.GetCurrentDirectory() + "\\auth"))
            {
                iniFile.IniWriteValue("tokens", "auth", Token);
                iniFile.IniWriteValue("expiry", "in", ExpiresIn);
                iniFile.IniWriteValue("expiry", "at", ExpiresAt.ToString());
                iniFile.IniWriteValue("tokens", "refresh", RefreshToken);
            }
        }
    }
}
