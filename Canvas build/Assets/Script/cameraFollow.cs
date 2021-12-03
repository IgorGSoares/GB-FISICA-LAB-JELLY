using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    void Start()
    {
        //offset = new Vector3(6, 6, -10);
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("bone_9");

        transform.position = new Vector3(player.transform.position.x/* + offset.x*/, player.transform.position.y/* + offset.y*/, this.transform.position.z);
    }
}
