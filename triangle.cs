using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class triangle : MonoBehaviour
{
    // Set the center point of the screen as the pivot point for the spinning animation
    private Vector3 pivotPoint = new Vector3(Screen.width / 2, Screen.height / 2);

    // Set the speed of the spinning animation
    public float spinSpeed = 1f;
    public static int score = 0;
    public static int lives = 3;
    public Text scoreCounter;
    public Text liveCounter;
    public Text sec;

    public static float speed = 0.75f;

    void Start()
    {
        // Get the current position of the mouse
        Vector3 mousePos = Input.mousePosition;

        // Calculate the angle between the mouse position and the pivot point
        float angle = Mathf.Atan2(mousePos.y - pivotPoint.y, mousePos.x - pivotPoint.x) * Mathf.Rad2Deg;

        // Rotate the triangle based on the angle and the spin speed
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle * spinSpeed));
        scoreCounter.text = "Score: " + score;
        liveCounter.text = "Lives: " + lives;

        //when no more lives, dead
        if (lives == 0)
        {
            SceneManager.LoadScene(sceneBuildIndex: 2);
        }
    }
    // Update is called once per frame
    void Update()
    {
        // Get the current position of the mouse
        Vector3 mousePos = Input.mousePosition;

        // Calculate the angle between the mouse position and the pivot point
        float angle = Mathf.Atan2(mousePos.y - pivotPoint.y, mousePos.x - pivotPoint.x) * Mathf.Rad2Deg;
        //Debug.Log(mousePos.x + " AND " + mousePos.y + " BUT " + pivotPoint);


        // Rotate the triangle based on the angle and the spin speed
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle * 1f));
        scoreCounter.text = "Score: " + score;
        liveCounter.text = "Lives: " + lives;
        sec.text = Circle.tsec.ToString();


        if (lives == 0)
        {
            SceneManager.LoadScene(sceneBuildIndex: 2);
        }
    }


}
