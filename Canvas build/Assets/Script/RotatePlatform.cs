using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    public bool rodar;
    public float rotationspeed;
    void Start()
    {
        rodar = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(rodar == true)
        {
            this.transform.Rotate(new Vector3(0, 0, rotationspeed));
        }
    }
}
