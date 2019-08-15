using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class result : MonoBehaviour
{

    public Text BreakBlock;    
    public Text BreakBlock1;
    public Text BreakBlock2;
    public Text BreakBlock3;
    public Text BreakBlock4;
    public Text result_Box;

    private int postit_creative = 0;
    private int ran = 0;
    private int ran2 = 0;

    private int level_stack; 
    private int exp_stack;
    private int money_stack;
    private int postit1_stack, postit2_stack, postit3_stack, postit4_stack, postit5_stack, postit6_stack, postit7_stack;
    private int postit8_stack, postit9_stack, postit10_stack,postit11_stack, postit12_stack, postit13_stack, postit14_stack, postit15_stack, postit16_stack;

    private double result_money = 0;
    private double result_exp = 0;


    System.Random r = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        objectcreate objectcreate = FindObjectOfType<objectcreate>();

        level_stack = PlayerPrefs.GetInt("saved_level");
        money_stack = PlayerPrefs.GetInt("saved_money");
        exp_stack = PlayerPrefs.GetInt("saved_exp");

        postit1_stack = PlayerPrefs.GetInt("saved_postit1");
        postit2_stack = PlayerPrefs.GetInt("saved_postit2");
        postit3_stack = PlayerPrefs.GetInt("saved_postit3");
        postit4_stack = PlayerPrefs.GetInt("saved_postit4");
        postit5_stack = PlayerPrefs.GetInt("saved_postit5");
        postit6_stack = PlayerPrefs.GetInt("saved_postit6");
        postit7_stack = PlayerPrefs.GetInt("saved_postit7");
        postit8_stack = PlayerPrefs.GetInt("saved_postit8");
        postit9_stack = PlayerPrefs.GetInt("saved_postit9");
        postit10_stack = PlayerPrefs.GetInt("saved_postit10");
        postit11_stack = PlayerPrefs.GetInt("saved_postit11");
        postit12_stack = PlayerPrefs.GetInt("saved_postit12");
        postit13_stack = PlayerPrefs.GetInt("saved_postit13");
        postit14_stack = PlayerPrefs.GetInt("saved_postit14");
        postit15_stack = PlayerPrefs.GetInt("saved_postit15");
        postit16_stack = PlayerPrefs.GetInt("saved_postit16");



        for (int i = 0; i < objectcreate.block1_destroy; i++)
        {
            ran = r.Next(1, 100);

            if (ran <= 50)
            {
                postit_creative++;

                ran2 = r.Next(1, 80);
                if (ran2 <= 5)
                {
                    postit1_stack++;
                    PlayerPrefs.SetInt("A1_", postit1_stack++);
                }
                else if (ran2 > 5 && ran2 <= 10)
                {
                    postit2_stack++;
                    PlayerPrefs.SetInt("A2_", postit2_stack++);
                }
                else if (ran2 > 10 && ran2 <= 15)
                {
                    postit3_stack++;
                    PlayerPrefs.SetInt("A3_", postit3_stack++);
                }
                else if (ran2 > 15 && ran2 <= 20)
                {
                    postit4_stack++;
                    PlayerPrefs.SetInt("A4_", postit4_stack++);
                }
                else if (ran2 > 20 && ran2 <= 25)
                {
                    postit5_stack++;
                    PlayerPrefs.SetInt("A5_", postit5_stack++);
                }
                else if (ran2 > 25 && ran2 <= 30)
                {
                    postit6_stack++;
                    PlayerPrefs.SetInt("A6_", postit6_stack++);
                }
                else if (ran2 > 30 && ran2 <= 35)
                {
                    postit7_stack++;
                    PlayerPrefs.SetInt("A7_", postit7_stack++);
                }
                else if (ran2 > 35 && ran2 <= 40)
                {
                    postit8_stack++;
                    PlayerPrefs.SetInt("A8_", postit8_stack++);
                }
                else if (ran2 > 40 && ran2 <= 45)
                {
                    postit9_stack++;
                    PlayerPrefs.SetInt("A9_", postit9_stack++);
                }
                else if (ran2 > 45 && ran2 <= 50)
                {
                    postit10_stack++;
                    PlayerPrefs.SetInt("A10_", postit10_stack++);
                }
                else if (ran2 > 50 && ran2 <= 55)
                {
                    postit11_stack++;
                    PlayerPrefs.SetInt("A11_", postit11_stack++);
                }
                else if (ran2 > 55 && ran2 <= 60)
                {
                    postit12_stack++;
                    PlayerPrefs.SetInt("A12_", postit12_stack++);
                }
                else if (ran2 > 60 && ran2 <= 65)
                {
                    postit13_stack++;
                    PlayerPrefs.SetInt("A13_", postit13_stack++);
                }
                else if (ran2 > 65 && ran2 <= 70)
                {
                    postit14_stack++;
                    PlayerPrefs.SetInt("A14_", postit14_stack++);
                }
                else if (ran2 > 70 && ran2 <= 75)
                {
                    postit15_stack++;
                    PlayerPrefs.SetInt("A15_", postit15_stack++);
                }
                else if (ran2 > 75 && ran2 <= 80)
                {
                    postit16_stack++;
                    PlayerPrefs.SetInt("A16_", postit16_stack++);
                }
            }
        }



        BreakBlock.text = "파괴한 블록의 수";
        BreakBlock1.text = "1단계 블록: " + objectcreate.block1_destroy.ToString() + "개 \n X 1골드 = " + objectcreate.block1_destroy + "\n 경험치 = " + objectcreate.block1_destroy * 2;
        BreakBlock2.text = "2단계 블록: " + objectcreate.block2_destroy.ToString() + "개 \n X 2골드 = " + objectcreate.block2_destroy * 2 + "\n 경험치 = " + objectcreate.block2_destroy * 3;
        BreakBlock3.text = "3단계 블록: " + objectcreate.block3_destroy.ToString() + "개 \n X 3골드 = " + objectcreate.block3_destroy * 3 + "\n 경험치 = " + objectcreate.block3_destroy * 6;
        BreakBlock4.text = "4단계 블록: " + objectcreate.block4_destroy.ToString() + "개 \n X 5골드 = " + objectcreate.block4_destroy * 5 + "\n 경험처 = " + objectcreate.block4_destroy * 10;

        result_money = objectcreate.block1_destroy + objectcreate.block2_destroy * 2 + objectcreate.block3_destroy * 3 + objectcreate.block4_destroy * 5;
        result_exp = objectcreate.block1_destroy * 2 + objectcreate.block2_destroy * 3 + objectcreate.block3_destroy * 6 + objectcreate.block4_destroy * 10;

        money_stack = money_stack + (int)result_money;
        exp_stack = exp_stack + (int)result_exp;


        //레벨업 구현 
        /*
        if (level_stack == 1)
        {

            if(exp_stack >= 1500)
            {
                exp_stack = exp_stack - 1500;
                if(exp_stack == 0)
                {
                    exp_stack = 1;
                }
                level_stack++;
            }
        }
        else if (level_stack == 2)
        {
            if(exp_stack >= 2500)
            {
                exp_stack = exp_stack - 2500;
                if(exp_stack == 0)
                {
                    exp_stack = 1;
                }
                level_stack++;
            }
        }*/

        PlayerPrefs.SetInt("saved_level", level_stack);
        PlayerPrefs.SetInt("saved_money", money_stack);
        PlayerPrefs.SetInt("saved_exp", exp_stack);
        PlayerPrefs.SetInt("saved_postit1", postit1_stack);
        PlayerPrefs.SetInt("saved_postit2", postit2_stack);
        PlayerPrefs.SetInt("saved_postit3", postit3_stack);
        PlayerPrefs.SetInt("saved_postit4", postit4_stack);
        PlayerPrefs.SetInt("saved_postit5", postit5_stack);
        PlayerPrefs.SetInt("saved_postit6", postit6_stack);
        PlayerPrefs.SetInt("saved_postit7", postit7_stack);
        PlayerPrefs.SetInt("saved_postit8", postit8_stack);
        PlayerPrefs.SetInt("saved_postit9", postit9_stack);
        PlayerPrefs.SetInt("saved_postit10", postit10_stack);
        PlayerPrefs.SetInt("saved_postit11", postit11_stack);
        PlayerPrefs.SetInt("saved_postit12", postit12_stack);
        PlayerPrefs.SetInt("saved_postit13", postit13_stack);
        PlayerPrefs.SetInt("saved_postit14", postit14_stack);
        PlayerPrefs.SetInt("saved_postit15", postit15_stack);
        PlayerPrefs.SetInt("saved_postit16", postit16_stack);

        result_Box.text = "총합 골드 : " + result_money.ToString() + "\t경험치 : " + result_exp.ToString();


        objectcreate.block1_destroy = 0;
        objectcreate.block2_destroy = 0;
        objectcreate.block3_destroy = 0;
        objectcreate.block4_destroy = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
