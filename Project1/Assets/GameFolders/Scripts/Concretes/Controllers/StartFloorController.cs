using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project1.Controllers
{
    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionExit(Collision collision)
        {
            PlayerController _playerController = collision.gameObject.GetComponent<PlayerController>();
            if(_playerController!=null)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
