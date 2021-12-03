using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject p;
    private Rigidbody2D rb;
    public float v;
    public int sentido = 1;


    public bool gravity = false;
    public bool destroy = false;
    public bool spin = false;
    public bool spawn = false;

    public GameObject s;

    //public Vector3 pos;
    //public GameObject clone;

    void Start()
    {
        s = GameObject.Find("spawn control");
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && gravity == true)
        {
            //Debug.Log("entrou");
            p = collision.gameObject.transform.parent.gameObject.transform.GetChild(8).gameObject;
            rb = p.GetComponent<Rigidbody2D>();
            if (v == 0)
                rb.gravityScale = 0;
            else
                rb.gravityScale = v * sentido;

            s.GetComponent<spawner>().propertiesG = new Vector2(v, sentido);
            s.GetComponent<spawner>().activeG = true;
        }

        else if (collision.gameObject.tag == "Player" && destroy == true)
        {
            Destroy(p);
            
        }

        else if (collision.gameObject.tag == "Player" && spin == true)
        {
            //Debug.Log("entrou");
            p.GetComponent<RotatePlatform>().rodar = true;
            p.GetComponent<RotatePlatform>().rotationspeed = v * sentido;

        }

        else if (collision.gameObject.tag == "Player" && spawn == true)
        {
            //Debug.Log("entrou");
            p.SetActive(true);

        }
    }
}

//private Rigidbody rb;
//public float v;
//public ConstantForce g;
//public int sentido = -1;
//void Start()
//{
//    rb = GetComponent<Rigidbody>();
//    g = gameObject.AddComponent<ConstantForce>();
//    Physics.gravity = new Vector3(0, 0, 0);
//    if (v == 0)
//        rb.useGravity = false;
//    else
//        g.force = new Vector3(0.0f, v * sentido, 0.0f);
//}
