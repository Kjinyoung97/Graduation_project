using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class pause : MonoBehaviour
{

    //public static AudioClip sound = GetComponent<AudioSource>();
    /*public AudioClip getsound()
    {
        return sound ;
    }*/

    public GameObject Panel,Panel2;
    // Start is called before the first frame update
    void Start()

    {
        GetComponent<AudioSource>().Play();
        //timerset timerset = FindObjectOfType<timerset>();
    }

    // Update is called once per frame
    public void stop()
    {
        Debug.Log("click");
        Time.timeScale = 0;
        GetComponent<AudioSource>().Pause();
        if (Panel)
        {
            Panel.gameObject.SetActive(true);
            //Panel2.gameObject.SetActive(false);
        }
      
    }

    void Update()
    {
        if (!Panel.activeSelf)
        {
            GetComponent<AudioSource>().UnPause();
        }
    }
}
