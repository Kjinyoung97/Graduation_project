using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class promot : MonoBehaviour
{

    private int level_stack, exp_stack;
    public int A_stack , B_stack, C_stack,D_stack;
  
    // Start is called before the first frame update
    void Start()
    {
        level_stack = PlayerPrefs.GetInt("saved_level");
        exp_stack = PlayerPrefs.GetInt("saved_exp");
    }

    // Update is called once per frame
    void Update()
    {
        if (level_stack == 1)
        {
            A_stack = PlayerPrefs.GetInt("saved_postit16");
            B_stack = PlayerPrefs.GetInt("saved_file6");
            C_stack = PlayerPrefs.GetInt("saved_sub2");
            if (A_stack >= 5 || B_stack >= 2 || C_stack >= 3)
            {
                A_stack = A_stack - 5;
                B_stack = B_stack - 2;
                C_stack = C_stack - 3;

                exp_stack = exp_stack - 1500;
                if (exp_stack == 0)
                {
                    exp_stack = 1;
                }
                level_stack = level_stack + 1;
            }
            PlayerPrefs.SetInt("saved_postit16", A_stack);
            PlayerPrefs.SetInt("saved_file6", B_stack);
            PlayerPrefs.SetInt("saved_sub2", C_stack);

        }

        //else if (level_stack == 2) { }
        PlayerPrefs.SetInt("saved_exp", exp_stack);
        PlayerPrefs.SetInt("saved_level", level_stack);


    }
}
