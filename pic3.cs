using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
public class pic3 : MonoBehaviour
{
    private int level_stack;
    public Text name3;
    public Text number3;
    // Start is called before the first frame update
    void Start()
    {
        level_stack = PlayerPrefs.GetInt("saved_level");

        if (level_stack == 1)
        {
            SpriteRenderer pic3 = GetComponent<SpriteRenderer>();
            pic3.sprite = Resources.Load<Sprite>("image/sub/C2");


            name3.text = "2번 교양책";
            number3.text = "[ 3개 ]";
        }
    }
    void Update()
    {

    }
}
