using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray3_code : MonoBehaviour
{
    private int libray3_count;
    public Text libray3_text;
    // Start is called before the first frame update
    void Start()
    {

        libray3_count = PlayerPrefs.GetInt("A3_");

        if (libray3_count == 0)
        {
            SpriteRenderer libray3_object = GetComponent<SpriteRenderer>();
            libray3_object.sprite = Resources.Load<Sprite>("image/postit/A3-흑백");

            libray3_count = 0;

            libray3_text.text = "[미획득]";
        }
        else
        {
            libray3_text.text = "[획득]";
        }

    }

    // Update is called once per frame
    void Update()
    {
        //libray3_text.text = "[ " + libray3_count.ToString() + "개" + " ]";
    }
}