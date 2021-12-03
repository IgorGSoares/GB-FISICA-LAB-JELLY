using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btSpawn : MonoBehaviour
{
    public int indexSpawn;
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
            spawner.GetComponent<spawner>().NewSpawn(indexSpawn);
        }
    }
}
