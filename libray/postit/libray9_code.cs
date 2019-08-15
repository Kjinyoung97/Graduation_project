using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray9_code : MonoBehaviour
{
    private int libray9_count;
    public Text libray9_text;
    // Start is called before the first frame update
    void Start()
    {

        libray9_count = PlayerPrefs.GetInt("A9_");

        if (libray9_count == 0)
        {
            SpriteRenderer libray9_object = GetComponent<SpriteRenderer>();
            libray9_object.sprite = Resources.Load<Sprite>("image/postit/A9-흑백");

            libray9_count = 0;

            libray9_text.text = "[미획득]";
        }
        else
        {
            libray9_text.text = "[획득]";
        }


    }

    // Update is called once per frame
    void Update()
    {
        //libray9_text.text = "[ " + libray9_count.ToString() + "개" + " ]";
    }
}