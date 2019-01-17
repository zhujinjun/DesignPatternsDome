using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SingletonPatterns
{
        
    /// <summary>
    /// 单例模式
    /// </summary>
    public class Singleton
    {       
        public static Singleton ingleton;
        /// <summary>
        /// private :防止外外部实例化
        /// </summary>
        private Singleton()
        {

        }

        /// <summary>
        /// 外部唯一能够访问实例的地方
        /// </summary>
        /// <returns></returns>
        public static Singleton GetSingleton()
        {
            if(ingleton == null)
            {
                ingleton = new Singleton();
            }
            return ingleton;
        }
    }
}
