using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{   
    [SerializeField]GameObject leverToPull;
    [SerializeField]GameObject CellToBomb;
    public Cell Cell;
    public Animator animator;
    public bool LeverOn;
    public bool Check = false;

        void OnTriggerStay2D(Collider2D col)
    {
        if(col.transform.CompareTag("Player") && Check == false)
            leverToPull.gameObject.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
               PullLever();
    }

        void OnTriggerExit2D(Collider2D col)
    {
        leverToPull.gameObject.SetActive(false);
    }

        private void PullLever()
    {
            leverToPull.gameObject.SetActive(false);
            Cell.GetComponent<Cell>().ableToBomb = true;
            animator.SetBool("LeverOn",true);
            Check = true;
    }
}