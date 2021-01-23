using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField]GameObject CellBlock;
    public bool ableToBomb = false;
        void Update()
        {
            if(ableToBomb == true)
                Bomb();
        }
        void OnTriggerStay2D(Collider2D col)
    {
        if(col.transform.CompareTag("Player"))
            CellBlock.gameObject.SetActive(true);
    }

        void OnTriggerExit2D(Collider2D col)
    {
        CellBlock.gameObject.SetActive(false);
    }
        void Bomb()
        {
                Destroy(gameObject);
                CellBlock.gameObject.SetActive(false);
        }
}