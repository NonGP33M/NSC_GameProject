using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField]GameObject Guide;
        void OnTriggerStay2D(Collider2D col)
    {
        if(col.transform.CompareTag("Player"))
            Guide.gameObject.SetActive(true);
    }

        void OnTriggerExit2D(Collider2D col)
    {
        Guide.gameObject.SetActive(false);
    }
        
}
