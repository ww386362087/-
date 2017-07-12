using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace 单例模式
{
    sealed class SIngleton1
    {
        private SIngleton1()
        {
            
        }

        private static SIngleton1 _instanceSIngleton;

        public static SIngleton1 InstanceSIngleton
        {
            get
            {
                if (_instanceSIngleton == null)
                {
                    _instanceSIngleton = new SIngleton1();
                }
                return _instanceSIngleton;
            }
        }
    }
}
