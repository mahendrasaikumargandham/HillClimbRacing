using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void EnterGame() {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnQuit() {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
