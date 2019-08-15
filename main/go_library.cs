using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class go_library : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void playbutton()
    {
        SceneManager.LoadScene("library");
    }
}

