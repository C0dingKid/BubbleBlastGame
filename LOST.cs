using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LOST : MonoBehaviour
{

    public Text highTxt;
    // Start is called before the first frame update
    void Start()
    {
        if (triangle.score > HOME.highS[HOME.mode])
        {
            HOME.highS[HOME.mode] = triangle.score;

        }
        highTxt.text = HOME.modeN[HOME.mode]+" highscore: " + HOME.highS[HOME.mode];

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void goHome()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    public void playAgain()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
        restart();
    }

    //reset all the game stats
    //mode 2 needs to reset the speed
    public void restart()
    {
        triangle.score = 0;
        triangle.lives = 3;
        if (HOME.mode == 2)
        {
            triangle.speed = 0.75f;
            Circle.ss = 1f;
        }
    }
}
