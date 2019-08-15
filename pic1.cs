using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
public class pic1 : MonoBehaviour
{
    private int level_stack;
    public Text name1;
    public Text number1;

    // Start is called before the first frame update
    void Start()
    {
        level_stack = PlayerPrefs.GetInt("saved_level");

        if (level_stack == 1)
        {
            SpriteRenderer pic1 = GetComponent<SpriteRenderer>();
            pic1.sprite = Resources.Load<Sprite>("image/postit/A16");

            name1.text = "16번 포스트잇";
            number1.text = "[ 5개 ]";

        }
    }
    void Update()
    {
        
    }
}
