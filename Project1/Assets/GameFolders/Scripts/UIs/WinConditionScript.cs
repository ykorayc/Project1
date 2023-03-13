using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project1.Managers;
using UnityEngine.SceneManagement;
namespace Project1.UIs
{
public class WinConditionScript : MonoBehaviour
{
        public void WindConditionYesClicked()
        {
           GameManager._instance.LoadLevel(SceneManager.GetActiveScene().buildIndex);
        }
}
    
}
