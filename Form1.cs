using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Configurações do servidor SMTP
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.office365.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("seu e-mail", "sua senha");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                // Criar a mensagem de e-mail
                MailMessage message = new MailMessage();
                message.From = new MailAddress("seu e-mail");
                message.To.Add(textBoxDes.Text);
                message.Subject = textBoxTitulo.Text;
                message.Body = richTextBoxCorpo.Text;
                message.IsBodyHtml = false;

                //Anexar um arquivo (opcional)
                Attachment attachment = new Attachment("Caminho da pasta onde esta os arquivos + \\" + textBoxAnexo.Text);
                message.Attachments.Add(attachment);


                // Enviar o e-mail
                smtpClient.Send(message);
                MessageBox.Show("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar o e-mail: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
