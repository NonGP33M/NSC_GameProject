using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorUsing : MonoBehaviour
{
    [SerializeField]GameObject InteractText;
        void OnTriggerStay2D(Collider2D col)
    {
        if(col.transform.CompareTag("Player"))
            InteractText.gameObject.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

        void OnTriggerExit2D(Collider2D col)
    {
        InteractText.gameObject.SetActive(false);
    }
}
