using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.IO;

namespace SafeLife.Lib
{
    /// <summary>
    /// Summary description for Pdf
    /// </summary>
    public static class Pdf
    {
        public static MemoryStream Create(string conteudo, string titulo, string assunto)
        {
            MemoryStream ms = new MemoryStream();
            using (TextReader textReader = new StringReader(conteudo))
            {
                Document document = new Document(PageSize.A4, 40, 40, 30, 30);

                PdfWriter pdfWriter = PdfWriter.GetInstance(document, ms);
                document.AddAuthor("Safe Life");
                document.AddCreationDate();
                document.AddTitle(titulo);
                document.AddCreator("Safe Life");
                document.AddSubject(assunto);
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                pdfWriter.SetEncryption(null, encoding.GetBytes("sAfelIfe2017*"), PdfWriter.ALLOW_PRINTING, PdfWriter.STRENGTH128BITS);

                pdfWriter.CloseStream = false;

                HTMLWorker htmlWorker = new HTMLWorker(document);

                document.Open();
                htmlWorker.StartDocument();
                htmlWorker.Parse(textReader);


                htmlWorker.EndDocument();
                htmlWorker.Close();
                document.Close();
            }

            ms.Position = 0;
            return ms;
        }
    }
}