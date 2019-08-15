using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray6_code : MonoBehaviour
{
    private int libray6_count;
    public Text libray6_text;
    // Start is called before the first frame update
    void Start()
    {

        libray6_count = PlayerPrefs.GetInt("A6_");

        if (libray6_count == 0)
        {
            SpriteRenderer libray6_object = GetComponent<SpriteRenderer>();
            libray6_object.sprite = Resources.Load<Sprite>("image/postit/A6-흑백");

            libray6_count = 0;

            libray6_text.text = "[미획득]";
        }
        else
        {
            libray6_text.text = "[획득]";
        }


    }

    // Update is called once per frame
    void Update()
    {
        //libray6_text.text = "[ " + libray6_count.ToString() + "개" + " ]";
    }
}