using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class libray_A2_code : MonoBehaviour
{
    private int libray_A2_count;
    public Text libray_A2_text;
    // Start is called before the first frame update
    void Start()
    {

    libray_A2_count = PlayerPrefs.GetInt("A2_");

        //libray_A2
        if (libray_A2_count == 0)
        {
            SpriteRenderer libray_A2_object = GetComponent<SpriteRenderer>();
            libray_A2_object.sprite = Resources.Load<Sprite>("image/postit/A2-흑백");

            libray_A2_count = 0;

            libray_A2_text.text = "[미획득]";
        }
        else
        {
            libray_A2_text.text = "[획득]";
        }

    }

    // Update is called once per frame
    void Update()
    {
        //libray_A2_text.text = "[ " + libray_A2_count.ToString() + "개" + " ]";
    }
}
