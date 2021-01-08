using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform Door2;

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
            col.transform.position = Door2.position;

    }
    
}