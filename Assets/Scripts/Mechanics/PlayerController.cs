using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Halo2D.Mechanics
{
    
    public class PlayerController : MonoBehaviour
    {
        public CharacterController2D controller;

        float horizontalMove = 0f;

        public float movementSpeed = 800f;

        bool jump = false;

        bool crouch = false;

        void Update()
        {
            Movement();

            Debug.Log("Jump" + Input.GetKeyDown(KeyCode.Space));
        }

        void FixedUpdate()
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
            jump = false;
        }

        void Movement()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * movementSpeed;

            if ((Input.GetKeyDown(KeyCode.Space)))
            {
                Debug.Log("I should be jumping");
                jump = true;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Debug.Log("I should be crouching");
                crouch = true;
            }

            else if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                Debug.Log("I should be standing");
                crouch = false;
            }
        }
    }
}