using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RegRuCertBuilder
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string text = Clipboard.GetText();
                if (text.Contains("Ваш сертификат предоставлен ниже"))
                    tbCert.Text = text;
            }
        }

        private void miCertClean_Click(object sender, EventArgs e)
        {
            tbCert.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\SSL_RegRu";            
            try
            {
                // Create folder for output
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                // Unix format                  
                string content = tbCert.Text.Trim().Replace("\r\n", "\n");

                // Public SSL key
                string cert = content.Substring("Ваш сертификат предоставлен ниже\n", "-----END CERTIFICATE-----");
                string certPath = $"{path}\\cert.crt";

                // SSL sign center bundle
                var bundle = new StringBuilder();
                bundle.Append(content.Substring("Промежуточный сертификат\n", "-----END CERTIFICATE-----"));
                bundle.Append("\n"); // don't use append line - Windows \r\n
                bundle.Append(content.Substring("Корневой сертификат\n", "-----END CERTIFICATE-----"));
                bundle.Append("\n"); // don't use append line - Windows \r\n
                bundle.Append(content.Substring("Запрос на получение сертификата\n", "-----END CERTIFICATE REQUEST-----"));
                string bundlePath = $"{path}\\bundle.crt";

                // Private SSL key
                string privateKey = content.Substring("Сохраните приватный ключ на локальном компьютере.\n",
                    "-----END RSA PRIVATE KEY-----");
                string privateKeyPath = $"{path}\\private.key";

                // Save all
                File.AppendAllText(certPath, cert);
                File.AppendAllText(bundlePath, bundle.ToString());
                File.AppendAllText(privateKeyPath, privateKey);

                var res = MessageBox.Show("Готово! Открыть папку?", "Готово", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res != DialogResult.Yes)
                    return;

                // Open explorer if agreed
                var process = new Process {
                    StartInfo = {
                        UseShellExecute = true,
                        FileName = @"explorer",
                        Arguments = path
                    }
                };
                process.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
