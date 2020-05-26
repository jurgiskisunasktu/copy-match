using System;
using System.Collections.Generic;
using System.Text;

namespace CopyMatch
{
    public class Singleton<T>
    where T : class, new()
    {
        private static T instance;
        private static readonly object padlock = new object();

        public static T Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new T();

                    return instance;
                }
            }
        }

        public Singleton()
        {

        }
    }
}
