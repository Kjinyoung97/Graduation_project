using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class timerset : MonoBehaviour
{

    public float time;
    public Text timeset;
    // Start is called before the first frame update
    void Start()
    {
        time = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        //timeset.text = Mathf.Ceil(time).ToString();
        timeset.text = "남은 시간  " + time.ToString("F2");
        time -= Time.deltaTime;
        if (time <= 0)
        {
            SceneManager.LoadScene("endgame");
        }
    }
}
