using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray15_code : MonoBehaviour
{
    private int libray15_count;
    public Text libray15_text;
    // Start is called before the first frame update
    void Start()
    {

        libray15_count = PlayerPrefs.GetInt("A15_");

        if (libray15_count == 0)
        {
            SpriteRenderer libray15_object = GetComponent<SpriteRenderer>();
            libray15_object.sprite = Resources.Load<Sprite>("image/postit/A15-흑백");

            libray15_count = 0;
            libray15_text.text = "[미획득]";
        }
        else
        {
            libray15_text.text = "[획득]";
        }


    }

    // Update is called once per frame
    void Update()
    {
       // libray15_text.text = "[ " + libray15_count.ToString() + "개" + " ]";
    }
}