using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Continue : MonoBehaviour
{
   // public static GameObject stop;
    //AudioClip sound = stop.GetComponent<pause>().getsound();

    public GameObject Panel;
    void Start()
    {
        Debug.Log("start");
    
    }
    public void buttoncall()
    {
        Debug.Log("click check");
        Time.timeScale = 1;

        if (Panel)
        {
            Panel.gameObject.SetActive(false);
        }
    }
}
