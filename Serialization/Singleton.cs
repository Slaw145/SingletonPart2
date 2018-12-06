using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureBeforeDeserialize
{
    [Serializable]
    public class Singleton
    {
        public static Singleton instance = new Singleton();

        private Singleton(){}

        protected Object GetInstance()
        {
            return instance;
        }
    }
}
