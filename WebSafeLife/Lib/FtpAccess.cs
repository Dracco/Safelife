using System.IO;
using System.Net;

namespace SafeLife.App_Code
{
    public static class FtpAccess
    {
        public static bool Download(string nomeArquivo)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://ftp.safelifesaude.com.br/" + nomeArquivo);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential("update@safelifesaude.com.br", "MTmJnWpl!3qJ");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();

                byte[] buffer = new byte[2048];

                DirectoryInfo di = Directory.CreateDirectory("/temp");
                FileStream newFile = new FileStream("/temp/" + nomeArquivo, FileMode.Create);
                int readCount = responseStream.Read(buffer, 0, buffer.Length);
                while (readCount > 0)
                {
                    newFile.Write(buffer, 0, readCount);
                    readCount = responseStream.Read(buffer, 0, buffer.Length);
                }
                newFile.Close();
                responseStream.Close();
                response.Close();
                return true;

            }
            catch (System.Exception)
            {
                return false;
                throw;
            }
        }
    }

}
