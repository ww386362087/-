using System;
using System.Collections.Generic;
using System.Text;

namespace 单例模式
{
    sealed class SIngletion3
    {
        private static readonly  SIngletion3 _insance;
        private SIngletion3()
        {
            
        }

        static SIngletion3()
        {
            _insance = new SIngletion3();
        }

        public static SIngletion3 Instance
        {
            get { return _insance; }
        }
    }
}
