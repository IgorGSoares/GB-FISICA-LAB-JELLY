using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    public GameObject s;
    void Start()
    {
        s = GameObject.Find("slime");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            collision.gameObject.transform.parent.gameObject.transform.GetChild(8).gameObject.GetComponent<controller>().jumpCount = 2;
        }
    }
}
