using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class file_create1 : MonoBehaviour
{
    private int A, B, C,file_create,ran,file_A,file_B,count;
    private bool IsSave, IsSave2;

    // Start is called before the first frame update
    void Start()
    {
        A = PlayerPrefs.GetInt("saved_postit1");
        B = PlayerPrefs.GetInt("saved_postit1");
        C = PlayerPrefs.GetInt("saved_postit1");
        file_A = PlayerPrefs.GetInt("saved_file1");
        file_B = PlayerPrefs.GetInt("saved_file2");
    }

    // Update is called once per frame
    void Update()
    {
        ran = Random.Range(1, 3);
    }
    public void click()
    {
        count = 8;
        //ran = Random.Range(1, 2);
        if (A+B+C >= count)
        {
            IsSave = PlayerPrefs.HasKey("saved_file1");
            IsSave2 = PlayerPrefs.HasKey("saved_file2");
            if(IsSave == false || IsSave2 == false)
            {
                file_A = 0;
                file_B = 0;
                PlayerPrefs.SetInt("saved_file1", file_A);
                PlayerPrefs.SetInt("saved_file2", file_B);

            }
            if (ran == 1)
            {
                file_A++;
            }
            else
            {
                file_B++;
            }
            if (A > count)
            {
                A =A- count;
            }
            else
            {
                count = count - A;
                A = 0;
                if (B > count)
                {
                    B = B - count;
                }
                else
                {
                    count = count - B;
                    B = 0;
                    C = C - count;
                }
            }
            PlayerPrefs.SetInt("saved_file1", file_A);
            PlayerPrefs.SetInt("saved_file2", file_B);
            PlayerPrefs.SetInt("saved_postit1", A);
            PlayerPrefs.SetInt("saved_postit2", B);
            PlayerPrefs.SetInt("saved_postit3", C);
        }

    }
}
