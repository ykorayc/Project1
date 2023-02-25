using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project1.Inputs;

namespace Project1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody _rigidbody;
        DefaultInput _input;
        bool isForceUp;
        [SerializeField] private float _force;
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
        }
        private void Update()
        {
            if (_input.isForceUp)
            {
                isForceUp = true;
            }
            else
            {
                isForceUp = false;
            }

        }
        private void FixedUpdate()
        {
            if(isForceUp)
            {
                _rigidbody.AddForce(Vector3.up*Time.deltaTime*_force,ForceMode.Force);
            }
        }
    }

}
