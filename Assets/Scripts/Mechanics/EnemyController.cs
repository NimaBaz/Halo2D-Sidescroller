using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Halo2D.Mechanics
{

    public class EnemyController : MonoBehaviour
    {

        internal Collider2D _collider;

        void Start()
        {
            _collider = GetComponent<Collider2D>();
        }

        void Update()
        {
            
        }
    }
}