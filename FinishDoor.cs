using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishDoor : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]GameObject NoKey;
    [SerializeField]GameObject HasKey;
    public bool KeyOn = false;

        void OnTriggerStay2D(Collider2D col)
    {  
        if(col.transform.CompareTag("Player"))
            if(KeyOn == false)
                NoKey.gameObject.SetActive(true);
            if(KeyOn == true)
                HasKey.gameObject.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E))
                    SceneManager.LoadScene("GameOver");
                    
    }

        void OnTriggerExit2D(Collider2D col)
    {
        NoKey.gameObject.SetActive(false);
    }
      
}
