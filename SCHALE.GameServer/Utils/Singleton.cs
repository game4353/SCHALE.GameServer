﻿namespace SCHALE.GameServer.Utils
{
    public abstract class Singleton<T>
        where T : new()
    {
        static T? instance;
        public static T Instance
        {
            get
            {
                instance ??= new T();

                return instance;
            }
            set => instance = value;
        }
    }
}
