using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class play_game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void playbutton()
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene("minigame");
    }
}

