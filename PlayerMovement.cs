using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
        
        public Animator animator;
        public CharacterController2D controller;
        public float runSpeed = 20f;
        float horizontalMove = 0f;
        bool jump = false;
        public bool Push;
       
        

         // Update is called once per frame
         void Update () {
               animator.SetFloat("speed", Mathf.Abs(horizontalMove));
                  
                 horizontalMove =  Input.GetAxisRaw("Horizontal") * runSpeed;

                 if (Input.GetButtonDown("Jump"))
                 {
                       jump = true;
                 }
                 
      }
            void OnTriggerStay2D(Collider2D col)
      {
        if(col.transform.CompareTag("Box"))
            animator.SetBool("Push", true);
         
      }

            void OnTriggerExit2D(Collider2D col)
      {
           animator.SetBool("Push", false);
      }

          void FixedUpdate ()
          {
                   // Move our character
                   controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
                   jump = false;
          }
          
}