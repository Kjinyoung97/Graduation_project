using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray4_code : MonoBehaviour
{
    private int libray4_count;
    public Text libray4_text;
    // Start is called before the first frame update
    void Start()
    {

        libray4_count = PlayerPrefs.GetInt("A4_");

        if (libray4_count == 0)
        {
            SpriteRenderer libray4_object = GetComponent<SpriteRenderer>();
            libray4_object.sprite = Resources.Load<Sprite>("image/postit/A4-흑백");

            libray4_count = 0;

            libray4_text.text = "[미획득]";
        }
        else
        {
            libray4_text.text = "[획득]";
        }

    }

    // Update is called once per frame
    void Update()
    {
      //  libray4_text.text = "[ " + libray4_count.ToString() + "개" + " ]";
    }
}