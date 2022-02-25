using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace CoderApplication
{
    public partial class Form1 : Form
    {
        //Блок описания и инициализации 

        #region Описание переменных формы 

        byte[] KEY = ASCIIEncoding.ASCII.GetBytes("Password");
        byte[] IV = ASCIIEncoding.ASCII.GetBytes("Password");
        byte[] secret = null;
        string pathSetting;

        #endregion

        #region Блок инициализации 
         
        public Form1()
        {
            InitializeComponent();
        }

        #endregion
      
        //--------------------------------------------


        //Методи формы 

        #region Метод: Кодирование пароля 

        /// <summary>
        /// Шифрование строки.
        /// </summary>
        /// <param name="originalString">Исходную строку</param>
        /// <returns>Зашифрованную строку</returns>
        /// <exception cref="ArgumentNullException">Это будет вызвано исключение, когда исходная строка нулевым или пустым</exception>
        public string Encrypt(string originalString, string additionalString)
        {
            byte[] toEncrypt = Encoding.UTF8.GetBytes(originalString);
            secret = Encoding.UTF8.GetBytes(additionalString);
            byte[] encryptData = ProtectedData.Protect(toEncrypt, secret, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptData);
        }

        #endregion
         
        #region Метод: Раскодирования пароля 

        /// <summary>
        /// Расшифровать закодированную строку
        /// </summary>
        /// <param name="cryptedString">Кодированая строка</param>
        /// <returns>Расшифрованая строка</returns>
        /// <exception cref="ArgumentNullException">Это будет вызвано исключение, когда Кодировка строки нулевым или пустым</exception>
        public string Decrypt(string cryptedString, string additionalString)
        {
            byte[] toDeEncrypt = Convert.FromBase64String(cryptedString);
            secret = Encoding.UTF8.GetBytes(additionalString);
            byte[] DeEncryptData = ProtectedData.Unprotect(toDeEncrypt, secret, DataProtectionScope.LocalMachine );
            return Encoding.UTF8.GetString(DeEncryptData);

            //if (String.IsNullOrEmpty(cryptedString))
            //{
            //    throw new ArgumentNullException("Строка, которая должна быть расшифрован не может быть нулевым");
            //}

            //DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            //MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cryptedString));
            //CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateDecryptor(key, IV), CryptoStreamMode.Read);
            //StreamReader reader = new StreamReader(cryptoStream);

            //return reader.ReadToEnd();
        }

        #endregion

        #region Метод: Создание файла настроек 

        /// <summary>
        /// Создает файл настроек  для программы PCN
        /// </summary>
        /// <param name="password">Пароль, который необходимо внести в файл настроек</param>
        private void CreateXMLSetting(String pathFile, String password)
        {
            using (System.Xml.XmlWriter writer = System.Xml.XmlWriter.Create(pathFile))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("PCNSettings");
                writer.WriteStartElement("UserSettings");

                writer.WriteStartElement("passwordReserv");
                writer.WriteString(password);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndElement();
            }
        }

        #endregion

        //--------------------------------------------


        //События формы 

        #region Событие: При загрузке формы 
 
        private void Form1_Load(object sender, EventArgs e)
        {
            userAsseccComboBox.SelectedIndex = 0;
            pathSetting = Application.StartupPath + "/" + "AdminKey.xml";
        }

        #endregion

        //--------------------------------------------


        //Кнопка сохранить настройки 

        #region Событие: Нажатие кнопки 

        private void button1_Click_1(object sender, EventArgs e)
        {
            String passwordString = "";
            switch (userAsseccComboBox.Text)
            {
                case "Администратор":
                    passwordString = Encrypt("a" + maskedPassword.Text.Trim(), "admin");
                    break;
                case "Пользователь":
                    passwordString = Encrypt("u" + maskedPassword.Text.Trim(), "admin");
                    break;
            }
            CodingPassword.Text = passwordString;
            CreateXMLSetting(pathSetting, passwordString);
            DeCodingPassword.Text = Decrypt(passwordString.Trim(), "admin");
        }

        #endregion

        //--------------------------------------------
    }
}
