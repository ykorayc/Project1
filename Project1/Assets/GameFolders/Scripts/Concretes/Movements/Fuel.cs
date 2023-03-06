using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project1.Movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] float maxFuel = 100f;
        [SerializeField] float currentFuel;
        [SerializeField] ParticleSystem _particle;
        public bool isEmpty => currentFuel < 1.0f;  //This is a property. We can use lambda expression to write more readeble code.

        private void Awake()
        {
            currentFuel = maxFuel;
        }
        public void FuelDecrease(float decrease)
        {
            currentFuel -= decrease;
            currentFuel = Mathf.Max(currentFuel, 0); //CurrentFuel can not smaller than "0"...
            if (_particle.isStopped)
            {
                _particle.Play();
            }
        }
        public void FuelIncrease(float increase)
        {
            currentFuel += increase;
            currentFuel = Mathf.Min(currentFuel, maxFuel);  //Because currentFuel can not bigger than maxFuel. 
            if (_particle.isPlaying)
            {
                _particle.Stop();  //If the particle is playing then stop. 
            }
            
        }

    }
}

