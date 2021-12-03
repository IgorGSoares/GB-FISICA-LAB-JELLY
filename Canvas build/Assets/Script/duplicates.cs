using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duplicates : MonoBehaviour
{
    public GameObject[] qtdP;
    //public int i = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        qtdP = GameObject.FindGameObjectsWithTag("Cube");


        //foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Cube"))
        //{
        //    if (fooObj.name == "slime")
        //    {
        //        qtdP[i] = fooObj;
        //        i++;
        //    }
        //}

        if (qtdP.Length > 1)
        {
            for (int i = 0; i < qtdP.Length - 1; i++)
            {
                Destroy(qtdP[i]);
                qtdP[i] = null;
            }
        }

    }
}
