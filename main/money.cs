using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class money : MonoBehaviour
{
    // Start is called before the first frame update

    //public Text Level;      //Level 값을 표시할 텍스트
    public Text EXP;        //EXP 값을 표시할 텍스트
    public Text MONEY;      //MONEY 값을 표시할 텍스트

    public static int level_stack;    //level 값
    public static int exp_stack,max_exp;    //exp 값
    public static int money_stack;       //money값

    public GameObject Button;

    private bool IsSave;     //저장된 데이터가 있는지 확인하기 위한 bool 값


    void Start()
    {
        IsSave = PlayerPrefs.HasKey("saved_money");     //saved_money 이라는 이름을 가진 키값이 존재하는지 확인

        //세이브 데이터가 없다면 모든 데이터값을 초기화
        if (!IsSave)
        {
            Debug.Log("저장된 데이터가 없습니다.");
            level_stack = 1;
            exp_stack = 0;
            money_stack = 0;
            max_exp = 1500;

            PlayerPrefs.SetInt("saved_level", level_stack);
            PlayerPrefs.SetInt("saved_exp", exp_stack);
            PlayerPrefs.SetInt("saved_money", money_stack);
            PlayerPrefs.SetInt("saved_max_exp", max_exp);
        }

        //세이브 데이터가 있다면 값을 불러옴
        else
        {
            Debug.Log("저장된 데이터가 있습니다.");
            level_stack = PlayerPrefs.GetInt("saved_level");
            exp_stack = PlayerPrefs.GetInt("saved_exp");
            max_exp = PlayerPrefs.GetInt("saved_max_exp");
            money_stack = PlayerPrefs.GetInt("saved_money");

        }

    }

    // Update is called once per frame
    void Update()
    {
        //Level.text = "[ 레벨 : " + level_stack.ToString() + " ]";
        EXP.text = exp_stack.ToString()+" / "+ max_exp;
        //EXP.text = exp_stack.ToString() + " / 7000 ";
        MONEY.text = money_stack.ToString() + "\\";

        PlayerPrefs.Save();

        if (exp_stack >= max_exp)
        {

            Button.SetActive(true);
        }
        else
        {
            Button.SetActive(false);
        }


    }
}
