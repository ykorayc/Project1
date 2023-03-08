using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project1.Managers;

namespace Project1.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClicked()
        {
            GameManager._instance.LoadLevel(1);
        }
        public void QuitClicked()
        {
            GameManager._instance.Exit();
        }
    }
}

