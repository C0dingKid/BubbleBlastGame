using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class HOME : MonoBehaviour
{
    public static int mode;
    public Text txtMode;
    public static float[] highS = {0f,0f,0f};
    public static string[] modeN = {"SS", "H", "S"};
    public Text chTxt;
    public static string[] chS = {"SPAM BUBBLES", "bet u 10 bucks u can't get 40","Gets faster over time!", "Don't let the bubbles touch the edge!\nThe shape wll always face where your mouse/finger is!\nAbsorb as many bubbles as you can!"};
    public Text highTxt;

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.backgroundColor = new Color(1f / 255f, 130f / 255f, 40f / 255f);
        mode = 2;
        txtMode.text = "Spicy";
        txtMode.color = new Color(1f / 255f, 130f / 255f, 40f / 255f);        
        highTxt.text = modeN[mode] + " highscore: " + highS[mode];
        chTxt.text = chS[mode];
    }

    // Update is called once per frame
    void Update()
    {
    }

    //select the different modes button
    public void hardMode()
    {
        if (mode == 0)
        {
            Camera.main.backgroundColor = new Color(158f / 255f, 6f / 255f, 6f / 255f);
            mode = 1;
            txtMode.text = "Hard";
            txtMode.color = new Color(158f / 255f, 6f / 255f, 6f / 255f);
            highTxt.text = modeN[mode] + " highscore: " + highS[mode];
            chTxt.text = chS[mode];

        }
        else if (mode == 1)
        {
            Camera.main.backgroundColor = new Color(1f / 255f, 130f / 255f, 40f / 255f);
            mode = 2;
            txtMode.text = "Spicy";
            txtMode.color = new Color(1f / 255f, 130f / 255f, 40f / 255f);
            highTxt.text = modeN[mode] + " highscore: " + highS[mode];
            chTxt.text = chS[mode];

        }
        else if (mode == 2)
        {
            Camera.main.backgroundColor = new Color(49f / 255f, 77f / 255f, 121f / 255f);
            mode = 0;
            txtMode.text = "Super Spicy";
            txtMode.color = new Color(49f / 255f, 77f / 255f, 121f / 255f);
            highTxt.text = modeN[mode] + " highscore: " + highS[mode];
            chTxt.text = chS[mode];

        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
        restart();
    }
    public void instruct()
    {
        chTxt.text = chS[3];
    }

    public void restart()
    {
        triangle.score = 0;
        triangle.lives = 3;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
