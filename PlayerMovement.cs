using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
        
        public Transform RespawnPoint;
        public Animator animator;
        public CharacterController2D controller;
        public float runSpeed = 20f;
        float horizontalMove = 0f;
        bool jump = false;

         // Update is called once per frame
         void Update () {
               animator.SetFloat("speed", Mathf.Abs(horizontalMove));
                  
                 horizontalMove =  Input.GetAxisRaw("Horizontal") * runSpeed;

                 if (Input.GetButtonDown("Jump"))
                 {
                       jump = true;
                 }
                 

          }
          void OnCollision(Collider2D col)
          {
                if(col.gameObject.tag ==  "FallingCheck")
                {
                      Debug.Log("gg");
                }
          }
          void FixedUpdate ()
          {
                   // Move our character
                   controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
                   jump = false;
          }
          
}