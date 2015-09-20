using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legopoly.Options
{
    [DataContract]
    public class OptionsMain
    {
        private static volatile OptionsMain instance;
        private static object syncRoot = new object();

        #region Private Constructor
        private OptionsMain()
        {
        }
        #endregion

        #region Singleton Access
        public static OptionsMain Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new OptionsMain();
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
    }
}
