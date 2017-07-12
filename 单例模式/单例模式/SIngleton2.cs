using System;
using System.Collections.Generic;
using System.Text;

namespace 单例模式
{
    sealed class SIngleton2
    {
        private SIngleton2()
        {
            
        }

        private static SIngleton2 _instance = null;
        private static object lockobj = new object();

        public static SIngleton2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockobj)
                    {
                        if(_instance== null)
                        _instance = new SIngleton2();
                    }
                }
                return _instance;
            }
        }
    }
}
