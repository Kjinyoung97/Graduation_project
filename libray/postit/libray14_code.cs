using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray14_code : MonoBehaviour
{
    private int libray14_count;
    public Text libray14_text;
    // Start is called before the first frame update
    void Start()
    {

        libray14_count = PlayerPrefs.GetInt("A14_");

        if (libray14_count == 0)
        {
            SpriteRenderer libray14_object = GetComponent<SpriteRenderer>();
            libray14_object.sprite = Resources.Load<Sprite>("image/postit/A14-흑백");

            libray14_count = 0;

            libray14_text.text = "[미획득]";
        }
        else
        {
            libray14_text.text = "[획득]";
        }


    }

    // Update is called once per frame
    void Update()
    {
       // libray14_text.text = "[ " + libray14_count.ToString() + "개" + " ]";
    }
}