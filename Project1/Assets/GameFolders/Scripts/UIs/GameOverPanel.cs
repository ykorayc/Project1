using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project1.Managers;

namespace Project1.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager._instance.LoadLevel();
        }
        public void NoClicked()
        {
            GameManager._instance.LoadMenuScene();
        }
    }

}
