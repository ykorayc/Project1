using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
namespace Project1.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager _instance { get; private set; }

        public event Action OnGameOver;

        public event Action OnMissionComplete;


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
        public void MissionComplete()
        {
            OnMissionComplete?.Invoke();
        }
        public void LoadLevel(int levelIndex=0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }

        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+levelIndex );
        }
        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }

        private IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("menu");
        }

        public void Exit()
        {
            Debug.Log("Exit Process");
            Application.Quit();
        }
    }
}