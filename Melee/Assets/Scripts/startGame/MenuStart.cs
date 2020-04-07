using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startGame()
    {
        // Console.WriteLine("_onStartGameEvent....");
        // AudioManager.instance.playBgMusic("scene1_bgm");
        AudioManager.instance.playSound("btnClick");
        Debug.Log("_onStartGameEvent....");
    }
    public void quitGame()
    {
        AudioManager.instance.playSound("btnClick");
        Application.Quit();
    }
}