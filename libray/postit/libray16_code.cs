using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray16_code : MonoBehaviour
{
    private int libray16_count;
    public Text libray16_text;
    // Start is called before the first frame update
    void Start()
    {

        libray16_count = PlayerPrefs.GetInt("A16_");

        if (libray16_count == 0)
        {
            SpriteRenderer libray16_object = GetComponent<SpriteRenderer>();
            libray16_object.sprite = Resources.Load<Sprite>("image/postit/A16-흑백");

            libray16_count = 0;

            libray16_text.text = "[미획득]";
        }
        else
        {
            libray16_text.text = "[획득]";
        }

    }

    // Update is called once per frame
    void Update()
    {
      //  libray16_text.text = "[ " + libray16_count.ToString() + "개" + " ]";
    }
}