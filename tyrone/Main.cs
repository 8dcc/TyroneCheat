using UnityEngine;

namespace TyroneCheat
{
    internal class Main : MonoBehaviour
    {
        vFPSController fpscontroller = FindObjectOfType<vFPSController>();
        vp_FPWeapon fpweapon = FindObjectOfType<vp_FPWeapon>();

        public void Start()
        {
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.End))
            {
                Loader.Unload();
            }

            fpscontroller.gravity = 0.5f;

            fpweapon.BobAmplitude = Vector3.zero;
            fpweapon.BobRate = Vector3.zero;
            fpweapon.ShakeAmplitude = Vector3.zero;
            fpweapon.ShakeSpeed = 0.0f;
        }

        public void OnGUI()
        {
            /* Watermark */
            Renderer.DrawString(new Vector2(10f, 10f), "TyroneHakZ420 (8dcc)", new Color(0.9f, 0.9f, 0.9f), false);
        }
    }
}
