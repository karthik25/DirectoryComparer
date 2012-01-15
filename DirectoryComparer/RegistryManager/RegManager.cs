using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace DirectoryComparer.RegistryManager
{
    public class RegManager
    {
        private static RegManager _regManager;

        RegManager()
        {

        }

        public static RegManager getInstance()
        {
            if (_regManager == null)
                _regManager = new RegManager();

            return _regManager;
        }

        public string getColumnPreferences()
        {
            return getValueByKey("UserColumnPreferences");
        }

        public string getDefaultLeftDir()
        {
            return getValueByKey("DefaultLeftDirectory");
        }

        public string getDefaultRightDir()
        {
            return getValueByKey("DefaultRightDirectory");
        }

        private string getValueByKey(string keyName)
        {
            string regPath = RegistryKeyMap.getRegKeyPath(keyName);
            RegistryKey columnKey = this.getReadableKeyPath(regPath.Split('\\'));
            if (columnKey != null && columnKey.GetValue(keyName) != null)
                return columnKey.GetValue(keyName).ToString();
            return string.Empty;
        }

        private RegistryKey getReadableKeyPath(string[] regSplit)
        {
            RegistryKey itKey = this.getRootKey(regSplit[0]);

            for (int i = 1; i < (regSplit.Length - 1); i++)
            {
                itKey = itKey.OpenSubKey(regSplit[i]);
                if (itKey == null) return null;
            }

            return itKey;
        }

        private RegistryKey getRootKey(string rootStr)
        {
            RegistryKey rootKey = null;

            switch (rootStr)
            {
                case "HKEY_CURRENT_USER":
                    rootKey = Registry.CurrentUser;
                    break;
                case "HKEY_LOCAL_MACHINE":
                    rootKey = Registry.LocalMachine;
                    break;
                case "HKEY_CLASSES_ROOT":
                    rootKey = Registry.ClassesRoot;
                    break;
                case "HKEY_USERS":
                    rootKey = Registry.Users;
                    break;
                case "HKEY_CURRENT_CONFIG":
                    rootKey = Registry.CurrentConfig;
                    break;
                default:
                    break;
            }

            return rootKey;
        }        

        public bool writeColumnPreferences(string columnStr)
        {
            return writeColumnValueByKey("UserColumnPreferences", columnStr);
        }

        public bool writeDefaultLeftDir(string columnStr)
        {
            return writeColumnValueByKey("DefaultLeftDirectory", columnStr);
        }

        public bool writeDefaultRightDir(string columnStr)
        {
            return writeColumnValueByKey("DefaultRightDirectory", columnStr);
        }

        private bool writeColumnValueByKey(string keyName, string columnStr)
        {
            try
            {
                string regPath = RegistryKeyMap.getRegKeyPath(keyName);
                string[] regPath_Split = regPath.Split("\\".ToCharArray());

                RegistryKey itKey = this.getWritableKeyPath(regPath_Split);

                if (itKey == null) return false;

                itKey.SetValue(keyName, columnStr, RegistryValueKind.String);

                itKey.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        private RegistryKey getWritableKeyPath(string[] regSplit)
        {
            RegistryKey itKey = this.getRootKey(regSplit[0]);

            for (int i = 1; i < (regSplit.Length - 1); i++)
            {
                itKey = itKey.CreateSubKey(regSplit[i]);
                if (itKey == null) return null;
            }

            return itKey;
        }
    }
}
