using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chegada : MonoBehaviour
{
    public GameObject level;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            level.GetComponent<scenes>().ChangeLvl();
        }
    }
}
