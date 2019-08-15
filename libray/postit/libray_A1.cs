using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray_A1 : MonoBehaviour
{

    private int libray_A1_count;
    public Text libray_A1_text;

    // Use this for initialization
    void Start()
    {
        //libray_A1
        libray_A1_count = PlayerPrefs.GetInt("A1_");

        if (libray_A1_count == 0)
        {
            SpriteRenderer libray_A1_object = GetComponent<SpriteRenderer>();
            libray_A1_object.sprite = Resources.Load<Sprite>("image/postit/A1-흑백");

            libray_A1_count = 0;

            libray_A1_text.text = "[미획득]";
        }
        else{
            libray_A1_text.text = "[획득]";
        }

    }

    // Update is called once per frame
    void Update()
    {
        //libray_A1_text.text = "[ " + libray_A1_count.ToString() + "개" + " ]";
    }
}
