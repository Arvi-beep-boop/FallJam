using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(this);
    }
    // public for now
    public void OnClickBtnQuit()
    {
        Application.Quit();
    }

    public void OnClickBtnPlay()
    {
        SceneManager.LoadScene("Level");
    }
}
