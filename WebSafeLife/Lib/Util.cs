using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace SafeLife.Lib
{
    internal class Util
    {
        private static readonly int timeout = 10 * 1000;

        /// <summary>
        /// Fonte: www.calculoimc.com.br/tabela-de-imc/
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="altura"></param>
        /// <returns></returns>
        public string ImcToString(double peso, double altura)
        {
            double imc = (peso / (Math.Pow(altura, 2)));

            if (imc < 17)
            {
                return "Muito Abaixo do Peso";
            }

            if (imc >= 17 && imc <= 18.49)
            {
                return "Abaixo do Peso";
            }

            if (imc >= 18.5 && imc <= 24.99)
            {
                return "Excelente";
            }

            if (imc >= 25 && imc <= 29.99)
            {
                return "Acima do Peso";
            }

            if (imc >= 30 && imc <= 34.99)
            {
                return "Obesidade Tipo I";
            }

            if (imc >= 35 && imc <= 39.99)
            {
                return "Obesidade Tipo II";
            }

            if (imc > 40)
            {
                return "Obesidade Tipo III";
            }

            return "";
        }

        public double ImcToDouble(double peso, double altura)
        {
            return (peso / (Math.Pow(altura, 2)));
        }

        public string GerarHashMd5(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
        public string RetornarMD5(string Senha)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                return RetonarHash(md5Hash, Senha);
            }
        }
        public bool ComparaMD5(string senhabanco, string Senha_MD5)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                var senha = RetornarMD5(senhabanco);
                if (VerificarHash(md5Hash, Senha_MD5, senha))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private string RetonarHash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
        private bool VerificarHash(MD5 md5Hash, string input, string hash)
        {
            StringComparer compara = StringComparer.OrdinalIgnoreCase;

            if (0 == compara.Compare(input, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Função para retornar um bool caso a string passada for um numero com 9 caracteres e sejam todos numeros (true)
        /// Caso contrario, para qualquer tipo de combinação retornara (false)
        /// </summary>
        /// <param name="numeros"></param>
        /// <returns></returns>
        public bool ValidaNumero(string numeros)
        {
            return Regex.IsMatch(numeros, @"^\d{9}$");
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.ASCII.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.ASCII.GetString(base64EncodedBytes);
        }
        public string GeraSenha(int tamanho)
        {
            string guid = Guid.NewGuid().ToString();

            Random random = new Random();

            string senha = "";
            for (Int32 i = 0; i <= tamanho; i++)
            {
                senha += guid.Substring(random.Next(1, guid.Length), 1);
            }

            return senha;
        }

        public static string GetJson(string endereco, string parametros)
        {
            var jsonEnviado = Encoding.UTF8.GetBytes(parametros);
            var requisicaoWeb = WebRequest.CreateHttp(endereco);
            var jsonText = "";

            requisicaoWeb.Timeout = timeout;
            requisicaoWeb.Method = "POST";
            requisicaoWeb.ContentType = "text/json";
            requisicaoWeb.ContentLength = jsonEnviado.Length;

            using (var stream = requisicaoWeb.GetRequestStream())
            {
                stream.Write(jsonEnviado, 0, jsonEnviado.Length);
                stream.Close();
            }

            //ler e exibir a resposta
            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                jsonText = reader.ReadToEnd();
                streamDados.Close();
                resposta.Close();
            }

            return jsonText;
        }

        public static T GetJsonAndDeserialize<T>(string endereco, string parametros, string metodo, string contentType)
        {
            T obj = Activator.CreateInstance<T>();


            var requisicaoWeb = WebRequest.Create(endereco);
            requisicaoWeb.Timeout = timeout;
            requisicaoWeb.Method = metodo;
            requisicaoWeb.ContentType = contentType;


            if (metodo == "POST")
            {
                var jsonEnviado = Encoding.UTF8.GetBytes(parametros);
                requisicaoWeb.ContentLength = jsonEnviado.Length;
                using (var stream = requisicaoWeb.GetRequestStream())
                {
                    stream.Write(jsonEnviado, 0, jsonEnviado.Length);
                    stream.Close();
                }
            }

            try
            {
                //ler e exibir a resposta
                using (var resposta = requisicaoWeb.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();
                    obj = JsonConvert.DeserializeObject<T>(objResponse.ToString());
                    streamDados.Close();
                    resposta.Close();
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
