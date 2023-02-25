using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project1.Inputs;
using Project1.Movements;
namespace Project1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        DefaultInput _input;
        bool isForceUp;
        [SerializeField] private float _force;
        private Mover _mover;
        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(GetComponent<Rigidbody>());
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
            _mover.FixedTick();
        }
    }

}
