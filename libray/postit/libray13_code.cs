using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray13_code : MonoBehaviour
{
    private int libray13_count;
    public Text libray13_text;
    // Start is called before the first frame update
    void Start()
    {

        libray13_count = PlayerPrefs.GetInt("A13_");

        if (libray13_count == 0)
        {
            SpriteRenderer libray13_object = GetComponent<SpriteRenderer>();
            libray13_object.sprite = Resources.Load<Sprite>("image/postit/A13-흑백");

            libray13_count = 0;

            libray13_text.text = "[미획득]";
        }
        else
        {
            libray13_text.text = "[획득]";
        }

    }

    // Update is called once per frame
    void Update()
    {
        //libray13_text.text = "[ " + libray13_count.ToString() + "개" + " ]";
    }
}