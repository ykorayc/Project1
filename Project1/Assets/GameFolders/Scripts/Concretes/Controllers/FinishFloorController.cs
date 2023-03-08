using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            }
            else
            {
                //Game Over...
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

}
