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


namespace desCoding
{
    public partial class Form1 : Form
    {
        #region Описание переменных формы 
        
        byte[] KEY = ASCIIEncoding.ASCII.GetBytes("Password");
        byte[] IV = ASCIIEncoding.ASCII.GetBytes("Password");
        string nameFileSetting;
        string pathSetting;

        #endregion

        #region Блок инициализации 

        public Form1()
        {
            InitializeComponent();
           
            nameFileSetting = "PCNSettings.xml";
            pathSetting = Application.StartupPath + "/" + nameFileSetting;
        }

        #endregion


        #region Список методов 

        #region Метод: Кодирование пароля 
        
        /// <summary>
        /// Шифрование строки.
        /// </summary>
        /// <param name="originalString">Исходную строку</param>
        /// <returns>Зашифрованную строку</returns>
        /// <exception cref="ArgumentNullException">Это будет вызвано исключение, когда исходная строка нулевым или пустым</exception>
        public string Encrypt(string originalString,byte[] key,byte[] IV)
        {
            if (String.IsNullOrEmpty(originalString))
            {
                throw new ArgumentNullException("Строка, которая должна быть расшифрован не может быть нулевым");
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateEncryptor(key, IV), CryptoStreamMode.Write);

            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(originalString);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();

            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }

        #endregion

        #region Метод: Раскодирования пароля 
        
        /// <summary>
        /// Расшифровать закодированную строку
        /// </summary>
        /// <param name="cryptedString">Кодированая строка</param>
        /// <returns>Расшифрованая строка</returns>
        /// <exception cref="ArgumentNullException">Это будет вызвано исключение, когда Кодировка строки нулевым или пустым</exception>
        public string Decrypt(string cryptedString, byte[] key,byte[] IV)
        {
            if (String.IsNullOrEmpty(cryptedString))
            {
                throw new ArgumentNullException("Строка, которая должна быть расшифрован не может быть нулевым");
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateDecryptor(key, IV), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);

            return reader.ReadToEnd();
        }

        #endregion


        
        #region Метод: Создание файла настроек 

        private void createXMLModem
            ( 
             System.Xml.XmlWriter writer,
             String NameModem, int ID,bool modemUsed, int comPort, String identModem,
             bool line1Used,bool line1Videlena,String identLine1,
             bool line2Used,bool line2Videlena,String identLine2,
             bool line3Used, bool line3Videlena, String identLine3,
             bool line4Used, bool line4Videlena, String identLine4,
             bool GSMline1Used,String GSMidentLine1,
             bool GSMline2Used,String GSMidentLine2
            )
        {
            #region Описание модема 
            
            writer.WriteStartElement(NameModem);

            writer.WriteStartAttribute("ID");
            writer.WriteValue(ID.ToString());
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("modemUsed");
            writer.WriteValue(modemUsed);
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("comPort");
            writer.WriteValue(comPort);
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("identModem");
            writer.WriteValue(identModem);
            writer.WriteEndAttribute();

            #endregion

            #region Описание линии 1 

            writer.WriteStartElement("Line1");

            writer.WriteStartAttribute("line1Used");
            writer.WriteValue(line1Used);
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("line1Videlena");
            writer.WriteValue(line1Videlena);
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("identLine1");
            writer.WriteValue(identLine1);
            writer.WriteEndAttribute();

            writer.WriteEndElement();

            #endregion

            #region Описание линии 2 

            writer.WriteStartElement("Line2");

            writer.WriteStartAttribute("line2Used");
            writer.WriteValue(line2Used);
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("line2Videlena");
            writer.WriteValue(line2Videlena);
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("identLine2");
            writer.WriteValue(identLine2);
            writer.WriteEndAttribute();

            writer.WriteEndElement();

            #endregion

            #region Описание линии 3 

            writer.WriteStartElement("Line3");

            writer.WriteStartAttribute("line3Used");
            writer.WriteValue(line3Used);
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("line3Videlena");
            writer.WriteValue(line3Videlena);
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("identLine3");
            writer.WriteValue(identLine3);
            writer.WriteEndAttribute();

            writer.WriteEndElement();

            #endregion

            #region Описание линии 4 

            writer.WriteStartElement("Line4");

            writer.WriteStartAttribute("line4Used");
            writer.WriteValue(line4Used);
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("line4Videlena");
            writer.WriteValue(line4Videlena);
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("identLine4");
            writer.WriteValue(identLine4);
            writer.WriteEndAttribute();

            writer.WriteEndElement();

            #endregion

            #region Описание GSM линии 1 

            writer.WriteStartElement("GSMLine1");

            writer.WriteStartAttribute("GSMline1Used");
            writer.WriteValue(GSMline1Used);
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("GSMidentLine1");
            writer.WriteValue(GSMidentLine1);
            writer.WriteEndAttribute();

            writer.WriteEndElement();

            #endregion

            #region Описание GSM линии 2 

            writer.WriteStartElement("GSMLine2");

            writer.WriteStartAttribute("GSMline2Used");
            writer.WriteValue(GSMline2Used);
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("GSMidentLine2");
            writer.WriteValue(GSMidentLine2);
            writer.WriteEndAttribute();

            writer.WriteEndElement();

            #endregion

            writer.WriteEndElement();
        
        }

        /// <summary>
        /// Создает файл настроек  для программы PCN
        /// </summary>
        /// <param name="password">Пароль, который необходимо внести в файл настроек</param>
        private void CreateXMLSetting(String pathFile,String password)
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

                writer.WriteStartElement("ModemSettings");

                createXMLModem
                    (
                       writer,"Модем",1, true, 1, "Прием сообщений с объекта",
                       false, true, "Городская линия",
                       true, true, "Городская линия",
                       false, false, "Городская линия",
                       true, true, "Городская линия",
                       true, "GSM линия",
                       true, "GSM линия"
                    );

                createXMLModem
                    (
                       writer,"Модем",2, true, 1, "Прием сообщений с объекта",
                       false, true, "Городская линия",
                       true, true, "Городская линия",
                       false, false, "Городская линия",
                       true, true, "Городская линия",
                       true, "GSM линия",
                       true, "GSM линия"
                    );

                writer.WriteEndElement();

                writer.WriteEndElement();
            }
        }


        #endregion

        #region Метод: Получает необходимую информацию с файла настроек PCN 
        
        /// <summary>
        /// Получает необходимую информацию с файла XML
        /// </summary>
        /// <param name="SettingFilePath">Путь к файлу xml</param>
        /// <param name="interestedInfo">Тег "Интересующая информация"</param>
        /// <returns>Строка, содержащая необходимую информацию</returns>
        private string getInfoSettings(string SettingFilePath, string interestedInfo)
        {
            System.Xml.XmlTextReader XMLSetting = new System.Xml.XmlTextReader(SettingFilePath);

            bool Flag = false;
            while (XMLSetting.Read())
            {
                switch (XMLSetting.NodeType)
                {
                    case System.Xml.XmlNodeType.Element:
                        if (XMLSetting.Name == interestedInfo)
                        {
                            Flag = true;
                        }
                        break;
                    case System.Xml.XmlNodeType.Text:

                        if (Flag) { return XMLSetting.Value; }

                        break;
                }
            }
            return null;
        }

        #endregion

        #endregion


        #region Событие: Кодирование пароля, сохранение в файл настроек

        private void сodingButton_Click(object sender, EventArgs e)
        {
            String passwordString = Encrypt("a"+maskedPassword.Text.Trim(), KEY, IV);
            CodingPassword.Text = passwordString;
            CreateXMLSetting(pathSetting, passwordString);
            String passwordStringFromXML = getInfoSettings(pathSetting, "passwordReserv");
            DeCodingPassword.Text = Decrypt(passwordStringFromXML.Trim(), KEY, IV);
        }

        #endregion


        #region Сохранить настройки в файл 
        
        private void createSettingButton_Click(object sender, EventArgs e)
        {
            String passwordString = Encrypt("a"+"admin", KEY, IV);
            try
            {
                CreateXMLSetting(pathSetting, passwordString);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                MessageBox.Show("Настройки сохранены корректно","Сообщение",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

                

        }

        #endregion
       

     

    }
}
