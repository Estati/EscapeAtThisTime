using UnityEngine;
using MelonLoader;

namespace EscapeAtThisTime
{
    public class EATT : MelonMod
    {
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                LoadMainMenuScene();
            }
        }

        private void LoadMainMenuScene()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("sl_mainmenu");
        }
    }
}
