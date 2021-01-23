using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillFloor : MonoBehaviour
{
    [SerializeField]Transform spawnPoint;
    [SerializeField]GameObject H1;
    [SerializeField]GameObject H2;
    [SerializeField]GameObject H3;

    public static int R = 0;


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.transform.CompareTag("Player"))
            col.transform.position = spawnPoint.position;
            R++;
            if(R == 1)
                Health();
            if(R == 2)
                Health2();
            if(R == 3)
                Health3();
    }
                

    public void Health()  
    {
        H3.gameObject.SetActive(false);
    }

    public void Health2()  
    {
        H3.gameObject.SetActive(false);
        H2.gameObject.SetActive(false);
    }

    public void Health3()  
    {
        H3.gameObject.SetActive(false);
        H2.gameObject.SetActive(false);
        H1.gameObject.SetActive(false);
        SceneManager.LoadScene("GameOver");
    }



}
