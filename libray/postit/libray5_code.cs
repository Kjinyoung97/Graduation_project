using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray5_code : MonoBehaviour
{
    private int libray5_count;
    public Text libray5_text;
    // Start is called before the first frame update
    void Start()
    {

        libray5_count = PlayerPrefs.GetInt("A5_");

        if (libray5_count == 0)
        {
            SpriteRenderer libray5_object = GetComponent<SpriteRenderer>();
            libray5_object.sprite = Resources.Load<Sprite>("image/postit/A5-흑백");

            libray5_count = 0;

            libray5_text.text = "[미획득]";
        }
        else
        {
            libray5_text.text = "[획득]";
        }


    }

    // Update is called once per frame
    void Update()
    {
      //  libray5_text.text = "[ " + libray5_count.ToString() + "개" + " ]";
    }
}