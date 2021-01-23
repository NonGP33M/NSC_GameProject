using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpGuide : MonoBehaviour
{
    [SerializeField]GameObject jumpGuide;
        void OnTriggerStay2D(Collider2D col)
    {
        if(col.transform.CompareTag("Player"))
            jumpGuide.gameObject.SetActive(true);
    }

        void OnTriggerExit2D(Collider2D col)
    {
        jumpGuide.gameObject.SetActive(false);
    }
        
}