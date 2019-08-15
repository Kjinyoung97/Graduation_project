using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class BAR : MonoBehaviour
{
    public Slider progress;
    private int level_stack;    //level 값
    private int exp_stack;    //exp 값
    private int money_stack;       //money값



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        level_stack = PlayerPrefs.GetInt("saved_level");
        exp_stack = PlayerPrefs.GetInt("saved_exp");
        money_stack = PlayerPrefs.GetInt("saved_money");

        if (level_stack == 1)
        {
            progress.maxValue = 1500;
        }
        else if (level_stack == 2)
        {
            progress.maxValue = 2500;
        }

        progress.value = exp_stack;

    }

    public void bar()
    {
       
    }
}
