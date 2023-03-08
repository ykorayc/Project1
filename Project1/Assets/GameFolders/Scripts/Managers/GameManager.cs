using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Project1.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager _instance { get; private set; }

        public event Action OnGameOver; 


        private void Awake() 
            //Singleton Pattern
        {
            SingletonThisGameObject();
        }

        private void SingletonThisGameObject()
        {
            if (_instance == null)
            {
                _instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }

        }

        public void GameOver()
        {
            OnGameOver?.Invoke(); // if OnGameOver!=null
        }
    }
}