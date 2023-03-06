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
        bool _canForceUp;
        public float _force => Force;
        Mover _mover;
        float _leftRight;
        Rotator _rotator;
        Fuel _fuel;

        

        public float _TurnSpeed => TurnSpeed;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }
        private void Update()
        {
           
            if (_input.isForceUp && !_fuel.isEmpty)
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;

            }
            _leftRight = _input.leftRight;

        }
        private void FixedUpdate()
        {

            _rotator.FixedTick(_leftRight);
            if (_canForceUp)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(.2f);
            }
            if(!_canForceUp)
            {
                _fuel.FuelIncrease(.01f);
            }

            
           
        }
    }

}
