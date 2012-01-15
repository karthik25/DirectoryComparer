using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DirectoryComparer.RegistryManager
{
    internal static class RegistryKeyMap
    {
        static Hashtable APP_REG_KEYS = null;

        static void LoadTable()
        {
            if (APP_REG_KEYS == null)
                APP_REG_KEYS = new Hashtable();

            APP_REG_KEYS.Add("UserColumnPreferences", @"HKEY_CURRENT_USER\Software\DirectoryComparer\Options\UserColumnPreferences");
            APP_REG_KEYS.Add("DefaultLeftDirectory", @"HKEY_CURRENT_USER\Software\DirectoryComparer\Options\DefaultLeftDirectory");
            APP_REG_KEYS.Add("DefaultRightDirectory", @"HKEY_CURRENT_USER\Software\DirectoryComparer\Options\DefaultRightDirectory");
        }

        public static string getRegKeyPath(string key)
        {
            if (APP_REG_KEYS == null)
                LoadTable();

            if (!APP_REG_KEYS.ContainsKey(key))
                return string.Empty;

            return APP_REG_KEYS[key].ToString();
        }
    }
}
