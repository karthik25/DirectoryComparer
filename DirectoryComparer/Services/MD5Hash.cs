// Thanks to http://stackoverflow.com/a/2150474/312219
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace DirectoryComparer.Services
{
    public class MD5Hash
    {
        public static string HashFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return HashFile(fs);
            }
        }

        public static string HashFile( FileStream stream )
        {
            StringBuilder sb = new StringBuilder();

            if( stream != null )
            {
                stream.Seek( 0, SeekOrigin.Begin );

                MD5 md5 = MD5CryptoServiceProvider.Create();
                byte[] hash = md5.ComputeHash( stream );
                foreach( byte b in hash )
                    sb.Append( b.ToString( "x2" ) );

                stream.Seek( 0, SeekOrigin.Begin );
            }

            return sb.ToString();
        }
    }
}
