using UnityEngine;

namespace tyrone
{
    public class Loader
    {
        public static void Init()
        {
            Loader.Load = new GameObject();

            Loader.Load.AddComponent<Main>();
            Loader.Load.AddComponent<Renderer>();

            UnityEngine.Object.DontDestroyOnLoad(Loader.Load);
        }

        public static void Unload()
        {
            _Unload();   
        }

        private static void _Unload()
        {
            GameObject.Destroy(Loader.Load);
        }

        private static GameObject Load;
    }
}
