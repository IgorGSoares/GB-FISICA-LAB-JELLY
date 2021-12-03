using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public GameObject spawner;
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
            //Debug.Log(collision.gameObject.name);
            Destroy(collision.gameObject.transform.parent.gameObject);
            spawner.GetComponent<spawner>().Respawn();
        }
    }
}
