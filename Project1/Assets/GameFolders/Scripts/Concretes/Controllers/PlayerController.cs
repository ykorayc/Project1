using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Project1.Inputs;
using Project1.Movements;
using Project1.Managers;
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
        bool canMove;

        public bool _canMove =>canMove;
        public float _TurnSpeed => TurnSpeed;

        private void OnEnable()
        {
            GameManager._instance.OnGameOver += HandleOnEventTriggered;  //Bu k�s�m �nemli. ��nk� bu k�s�mda instance ald���m�z i�in GameManager, PlayerController'dan
                                                                         //�nce olu�mal�. Bunu yapmak i�in de Script Execution Order'a bakmak zorunday�z.
            GameManager._instance.OnMissionComplete += HandleOnEventTriggered;
        }
        private void OnDisable()
        {
            GameManager._instance.OnGameOver -= HandleOnEventTriggered;             //Farkl� eventlere ayn� metodlar� ekleyebiliriz.
            GameManager._instance.OnMissionComplete -= HandleOnEventTriggered;  
        }
        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }
        private void Start()
        {
            canMove = true;
        }
        private void Update()
        {
            if (!canMove) return;
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
        
            
        private void HandleOnEventTriggered()
        {
            canMove = false;
            _canForceUp = false;
            _fuel.FuelIncrease(0f);
            _leftRight = 0f;
        }

    }

}
