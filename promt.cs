using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class promt : MonoBehaviour
{
    private int level_stack;
    // Start is called before the first frame update
    void Start()
    {
        level_stack = PlayerPrefs.GetInt("saved_level");

    }

    // Update is called once per frame
    void Update()
    {
        if (level_stack == 1)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/UI/신입생");

        }
        else if (level_stack == 2)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/UI/2학년");

        }
        else if (level_stack == 3)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/UI/3학년");

        }
        else if (level_stack == 4)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/UI/4학년");

        }

        else if (level_stack == 5)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/UI/석사");

        }
        else if (level_stack == 6)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/UI/박사");

        }
        else if (level_stack == 7)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/UI/연구원");

        }
        else if (level_stack == 8)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/UI/교수");

        }

    }
}
