using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project1.Controllers;

namespace Project1.Movements
{
    public class Mover
    {
        Rigidbody _rigidbody;

        public Mover(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }
        
        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up*Time.deltaTime*75f);//Relative to our position.
        }
    
    }
}

