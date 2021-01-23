using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{
   [SerializeField]GameObject KeyGuide;
   [SerializeField]GameObject Door;

        void OnTriggerStay2D(Collider2D col)
    {
        if(col.transform.CompareTag("Player"))
            KeyGuide.gameObject.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
               Pickup();
    }

        void OnTriggerExit2D(Collider2D col)
    {
        KeyGuide.gameObject.SetActive(false);
    }

        private void Pickup()
    {
            Destroy(gameObject);
            KeyGuide.gameObject.SetActive(false);
            Door.GetComponent<FinishDoor>().KeyOn = true;
            
    }
}