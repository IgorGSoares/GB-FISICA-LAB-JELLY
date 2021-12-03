using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canhão : MonoBehaviour
{
    public GameObject prefab;
    public GameObject origin;
    public bool ready;
    public static GameObject novo;
    public float intensity;

    public Vector3 pos;
    void Start()
    {
        
    }
    void Update()
    {
        pos = new Vector3(origin.transform.position.x, origin.transform.position.y, origin.transform.position.z);

        if (Input.GetKey(KeyCode.Z) && ready == true)
        {
            ready = false;
            novo = Instantiate(prefab, origin.transform.position, transform.rotation);
            novo.transform.tag = "Player";
            //novo.GetComponent<CircleCollider2D>().enabled = true;
            novo.transform.GetChild(8).GetComponent<Rigidbody2D>().AddForce(new Vector2(origin.transform.position.x * intensity,
                origin.transform.position.y * intensity));
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject.transform.parent.gameObject);
            ready = true;
        }
    }
}
