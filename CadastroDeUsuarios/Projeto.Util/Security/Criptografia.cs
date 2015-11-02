using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;


namespace Projeto.Util.Security
{
    public class Criptografia
    {
        public static string EcriptarMD5(string valor)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(valor));

            return BitConverter.ToString(hash).Replace("-", string.Empty);
        }
    }
}