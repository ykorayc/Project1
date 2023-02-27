using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project1.Inputs;
using Project1.Movements;
namespace Project1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float TurnSpeed=35f;
        [SerializeField] float Force=75f;
        DefaultInput _input;
        bool isForceUp;
        public float _force => Force;
        Mover _mover;
        float _leftRight;
        Rotator _rotator;

        public float _TurnSpeed => TurnSpeed;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
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
            _leftRight = _input.leftRight;

        }
        private void FixedUpdate()
        {

            _rotator.FixedTick(_leftRight);
            if (isForceUp)
            {
                _mover.FixedTick();
            }

            
           
        }
    }

}
