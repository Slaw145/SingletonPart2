using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSingleton
{
    public interface IMoq
    {
        bool SomeLogic(int test);
    }

    public class Singleton: IMoq
    {
        private static Singleton _instance;
        public static Singleton Instance {get{return _instance;}}

        private Singleton(){}

        public static Singleton getInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public static void resetForTesting()
        {
            _instance = null;
        }

        public bool SomeLogic(int test)
        {
            if(test==3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class SomeClass
    {
        private readonly IMoq _iMoq;

        public SomeClass(IMoq iMoq)
        {
            _iMoq = iMoq;
        }

        public bool SomeLogic(int test)
        {
            return _iMoq.SomeLogic(test);
        }
    }
}
