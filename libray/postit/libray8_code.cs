using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray8_code : MonoBehaviour
{
    private int libray8_count;
    public Text libray8_text;
    // Start is called before the first frame update
    void Start()
    {

        libray8_count = PlayerPrefs.GetInt("A8_");

        if (libray8_count == 0)
        {
            SpriteRenderer libray8_object = GetComponent<SpriteRenderer>();
            libray8_object.sprite = Resources.Load<Sprite>("image/postit/A8-흑백");

            libray8_count = 0;

            libray8_text.text = "[미획득]";
        }
        else
        {
            libray8_text.text = "[획득]";
        }


    }

    // Update is called once per frame
    void Update()
    {
        //libray8_text.text = "[ " + libray8_count.ToString() + "개" + " ]";
    }
}