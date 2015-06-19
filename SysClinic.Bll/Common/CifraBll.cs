using System.Security.Cryptography;
using System.Text;

namespace SysClinic.Bll.Common
{
    public class CifraBll
    {
        public string GetCriptografiaMD5(string valor)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] valorCriptografado = md5Hasher.ComputeHash(Encoding.Default.GetBytes(valor));
            StringBuilder retorno = new StringBuilder();
            for (int i = 0; i < valorCriptografado.Length; i++)
            {
                retorno.Append(valorCriptografado[i].ToString("x2"));
            }
            return retorno.ToString();
        }
    }
}
