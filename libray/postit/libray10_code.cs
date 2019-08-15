using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray10_code : MonoBehaviour
{
    private int libray10_count;
    public Text libray10_text;
    // Start is called before the first frame update
    void Start()
    {

        libray10_count = PlayerPrefs.GetInt("A10_");

        if (libray10_count == 0)
        {
            SpriteRenderer libray10_object = GetComponent<SpriteRenderer>();
            libray10_object.sprite = Resources.Load<Sprite>("image/postit/A10-흑백");

            libray10_count = 0;

            libray10_text.text = "[미획득]";
        }
        else
        {
            libray10_text.text = "[획득]";
        }


    }

    // Update is called once per frame
    void Update()
    {
       // libray10_text.text = "[ " + libray10_count.ToString() + "개" + " ]";
    }
}