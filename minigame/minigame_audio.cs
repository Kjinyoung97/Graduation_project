using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame_audio : MonoBehaviour
{
     
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            //GetComponent<AudioSource>().Pause();
        }
        /*if (Time.timeScale == 1)
        {
            GetComponent<AudioSource>().Play();
        }*/
        
    }
}
