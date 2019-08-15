using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray12_code : MonoBehaviour
{
    private int libray12_count;
    public Text libray12_text;
    // Start is called before the first frame update
    void Start()
    {

        libray12_count = PlayerPrefs.GetInt("A12_");

        if (libray12_count == 0)
        {
            SpriteRenderer libray12_object = GetComponent<SpriteRenderer>();
            libray12_object.sprite = Resources.Load<Sprite>("image/postit/A12-흑백");

            libray12_count = 0;

            libray12_text.text = "[미획득]";
        }
        else
        {
            libray12_text.text = "[획득]";
        }


    }

    // Update is called once per frame
    void Update()
    {
       // libray12_text.text = "[ " + libray12_count.ToString() + "개" + " ]";
    }
}