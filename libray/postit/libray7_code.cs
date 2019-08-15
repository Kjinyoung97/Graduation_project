using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray7_code : MonoBehaviour
{
    private int libray7_count;
    public Text libray7_text;
    // Start is called before the first frame update
    void Start()
    {

        libray7_count = PlayerPrefs.GetInt("A7_");

        if (libray7_count == 0)
        {
            SpriteRenderer libray7_object = GetComponent<SpriteRenderer>();
            libray7_object.sprite = Resources.Load<Sprite>("image/postit/A7-흑백");

            libray7_count = 0;

            libray7_text.text = "[미획득]";
        }
        else
        {
            libray7_text.text = "[획득]";
        }


    }

    // Update is called once per frame
    void Update()
    {
        //libray7_text.text = "[ " + libray7_count.ToString() + "개" + " ]";
    }
}