using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Project1.Managers;
namespace Project1.Controllers
{
    public class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController _playerController = collision.gameObject.GetComponent<PlayerController>();
            if(_playerController!=null)
            {
                // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                GameManager._instance.GameOver();
            }
        }
    }

}
