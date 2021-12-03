using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenes : MonoBehaviour
{
    public int next;
    //public int previous;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLvl()
    {
        SceneManager.LoadScene(next);
    }

    public void doExitGame()
    {
        Application.Quit();
    }
}
