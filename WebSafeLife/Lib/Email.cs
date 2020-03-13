using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;


namespace SafeLife.Lib
{

    public class Email
    {
        #region Atributos
        private SmtpClient Servidor;
        private MailMessage mail;
        private List<Attachment> Anexos;
        private ArrayList copy = new ArrayList();
        private ArrayList copyOccult = new ArrayList();
        private ArrayList allEmailsDistinct = new ArrayList();
        private String from = null, to = null, subject = null, bodyMessage = null;
        #endregion

        #region construtores
        /// <summary>
        /// Cria uma nova conexão com o Servidor de SMTP padrão
        /// </summary>
        public Email()
        {
            this.Servidor = new SmtpClient("mail.draccoSolutions.com", 26);
            this.Servidor.Credentials = new System.Net.NetworkCredential("admin@draccoSolutions.com", "XW&KJ9{cdMWk");
            this.Servidor.EnableSsl = false;
            this.Anexos = new List<Attachment>(5);
        }

        #endregion

        #region Setando Atributos do Email
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        public void To(string email)
        {
            this.to = email.ToLower();
        }

        public void addCopy(string email)
        {
            this.copy.Add(email.ToLower());
        }

        public void addCopyOccult(string email)
        {
            this.copyOccult.Add(email.ToLower());
        }

        public void From(string email)
        {
            this.from = email;
        }

        public void Subject(string subject)
        {
            this.subject = subject;
        }

        public void addAttachment(Attachment anexo)
        {
            this.Anexos.Add(anexo);
        }

        public void Message(string bodyMessage)
        {
            this.bodyMessage = bodyMessage;
        }
        #endregion

        #region Validações
        private bool isFrom()
        {
            return this.from != null && this.from != string.Empty;
        }

        private bool isTo()
        {
            return this.to != null && this.to != string.Empty;
        }

        private bool isSubject()
        {
            return this.subject != null;
        }

        private bool isMessage()
        {
            return this.bodyMessage != null;
        }

        private bool isOk()
        {
            if (this.isFrom() && this.isTo() && this.isSubject() && this.isMessage())
                return true;

            return false;
        }
        #endregion

        public bool Send()
        {
            try
            {
                if (this.isOk())
                {
                    this.mail = new MailMessage(this.from, this.to, this.subject, this.bodyMessage);
                    allEmailsDistinct.Add(this.to);

                    if (this.copyOccult.Count > 0)
                    {
                        foreach (Object obj in copyOccult)
                        {
                            if (!allEmailsDistinct.Contains(obj))
                            {
                                allEmailsDistinct.Add(obj);
                                this.mail.Bcc.Add(obj.ToString());
                            }
                        }
                    }

                    if (this.copy.Count > 0)
                    {
                        foreach (Object obj in copy)
                        {
                            if (!allEmailsDistinct.Contains(obj))
                            {
                                allEmailsDistinct.Add(obj);
                                this.mail.CC.Add(obj.ToString());
                            }
                        }
                    }

                    if (this.Anexos.Count > 0)
                    {
                        foreach (Attachment a in this.Anexos)
                        {
                            this.mail.Attachments.Add(a);
                        }
                    }

                    this.mail.IsBodyHtml = true;
                    this.Servidor.Send(this.mail);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}