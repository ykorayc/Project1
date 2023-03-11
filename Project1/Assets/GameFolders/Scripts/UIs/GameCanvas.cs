using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project1.Managers;

namespace Project1.UIs
{
    
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameObject _GameOverObjects;
        private void Awake()
        {
            if (_GameOverObjects.activeSelf)
            {
                _GameOverObjects.SetActive(false);
            }
        }
        private void OnEnable()
        {
            GameManager._instance.OnGameOver += GameOverCanvas;
        }
        private void OnDisable()
        {
            GameManager._instance.OnGameOver -= GameOverCanvas;
        }
        private void GameOverCanvas()
        {
            if (!_GameOverObjects.activeSelf)
            {
                _GameOverObjects.SetActive(true);
            }
        }


    }
    

}
