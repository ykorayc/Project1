using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Project1.Managers;
namespace Project1.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _FinishParticle;

        private void OnCollisionEnter(Collision collision)
        {
            PlayerController _playerController = collision.gameObject.GetComponent<PlayerController>();
            if (_playerController == null) return;
            if (collision.GetContact(0).normal.y == -1)
            {
                _FinishParticle.SetActive(true);
                GameManager._instance.MissionComplete();
            }
            else
            {
                //Game Over...
                // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                GameManager._instance.GameOver();
            }
        }
    }

}
