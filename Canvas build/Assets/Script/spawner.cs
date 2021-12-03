using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Vector2 spawnPoint = new Vector2(-2.82f, 8.06f);
    public Vector2[] newPoints;
    public GameObject player;
    public static GameObject novo;

    public bool activeG = false;
    public Vector2 propertiesG;

    public bool isInverse = false;
    public float valor;

    void Start()
    {
        novo = player;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewSpawn(int index)
    {
        spawnPoint = new Vector2(newPoints[index].x, newPoints[index].y);
        //7.7125f, 2.6933f
    }

    public void Respawn()
    {
        novo = Instantiate(player, spawnPoint, transform.rotation);
        novo.transform.name = "slime";
        novo.transform.tag = "Cube";
        //novo.GetComponent<CircleCollider2D>().enabled = true;
        if(activeG == true)
        {
            GameObject p = novo.gameObject.transform.GetChild(8).gameObject;
            Rigidbody2D rb = p.GetComponent<Rigidbody2D>();
            rb.gravityScale = propertiesG.x * propertiesG.y;
        }

        if(isInverse == true)
        {
            GameObject p = novo.gameObject.transform.GetChild(8).gameObject;
            Rigidbody2D rb = p.GetComponent<Rigidbody2D>();
            rb.gravityScale = valor;
        }
    }
}
