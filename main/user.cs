﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
public class user : MonoBehaviour
{
    private int level_count;
    // Start is called before the first frame update
    void Start()
    {
        money money = FindObjectOfType<money>();

        Debug.Log(level_count);

    }

    // Update is called once per frame
    void Update()
    {
 
        if (money.level_stack == 1)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/back/신입생");

        }
        else if (money.level_stack == 2)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/back/2학년_image");

        }
         else if (money.level_stack == 3)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/back/재학생 (3학년)");

        }
        else if (money.level_stack == 4)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/back/취업준비 (4학년)");

        }
        else if (money.level_stack == 5)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/back/논문 머리박 (석사)");

        }
        /*else if (money.level_stack == 6)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/박사");

        }*/
        else if (money.level_stack == 7)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/back/연구원");

        }
        else if (money.level_stack == 8)
        {
            SpriteRenderer user_image = GetComponent<SpriteRenderer>();
            user_image.sprite = Resources.Load<Sprite>("image/back/교수");

        }
    }
}
