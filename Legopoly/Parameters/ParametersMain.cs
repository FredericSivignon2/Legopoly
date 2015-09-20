using FoundationLibraries.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Parameters
{
    [DataContract]
    public class ParametersMain
    {
        private static volatile ParametersMain instance;
        private static object syncRoot = new object();

        private const string directory = "LEGOPoly";
        private const string fileName = "parameters.xml";

        #region Private Constructor
        public ParametersMain()
        {

        }
        #endregion

        #region Singleton Access
        public static string GetParametersFilePath()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), directory);
            if (Directory.Exists(path) == false)
                Directory.CreateDirectory(path);

            return Path.Combine(path, fileName);
        }

        public static ParametersMain Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ParametersMain();
                    }
                }
                return instance;
            }
        }
        #endregion

        /// <summary>
        /// Defines the number of experience points when a user is created.
        /// </summary>
        [DataMember]
        public int DefaultExperiencePoints { get; set; } = 40;

        [DataMember]
        public Shop Shop { get; set; } = new Shop();


        public void CreateDefault()
        {
            string filePath = GetParametersFilePath();

            XmlSerializationHelper.HelperUTF8.Indent = true;
            XmlSerializationHelper.HelperUTF8.ToFile<ParametersMain>(filePath, this);

            LPMessageBox.ShowMessage("Le fichier de paramètre a été généré dans:\r\n\r\n" + filePath);
        }
    }
}
