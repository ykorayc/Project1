using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project1.Controllers;

namespace Project1.Movements
{
    public class Rotator 
    {
        Rigidbody _rigidbody;
        PlayerController _playerController;

        public Rotator(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = _playerController.GetComponent<Rigidbody>();
        }
        public void FixedTick(float direction)  //Important code for using Rigidbody and Transform together.
        {
            if (direction == 0)
            {
                if (_rigidbody.freezeRotation)
                {
                    _rigidbody.freezeRotation = false;
                }
                return;
            }


            if(!_rigidbody.freezeRotation)
            {
                _rigidbody.freezeRotation = true; //Because i want to controlling rotation myself.
            }
            _playerController.gameObject.transform.Rotate(Vector3.back * direction * Time.deltaTime * _playerController._TurnSpeed);
        }
    }
}
