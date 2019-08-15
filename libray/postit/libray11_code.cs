using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray11_code : MonoBehaviour
{
    private int libray11_count;
    public Text libray11_text;
    // Start is called before the first frame update
    void Start()
    {

        libray11_count = PlayerPrefs.GetInt("A11_");

        if (libray11_count == 0)
        {
            SpriteRenderer libray11_object = GetComponent<SpriteRenderer>();
            libray11_object.sprite = Resources.Load<Sprite>("image/postit/A11-흑백");

            libray11_count = 0;

            libray11_text.text = "[미획득]";
        }
        else
        {
            libray11_text.text = "[획득]";
        }

    }

    // Update is called once per frame
    void Update()
    {
       // libray11_text.text = "[ " + libray11_count.ToString() + "개" + " ]";
    }
}