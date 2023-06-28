using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circle : MonoBehaviour
{
    // Set the radius of where they spawn
    public float radius = 3f;

    // Set the target position for the circle sprite
    public Vector3 targetPos = new Vector3(0f, 0f, 0f);

    public static float ss = 0.75f;

    //prefabs
    public GameObject circle;

    //the time since runtime of the game scene in seconds
    public static float tsec = 0f;

    public Text highTxt;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CircleSpawn());
        highTxt.text = HOME.modeN[HOME.mode] + " highscore: " + HOME.highS[HOME.mode];

    }
    void Update()
    {
        tsec = Time.timeSinceLevelLoad;
    }

    IEnumerator CircleSpawn()
    {
        while (true)
        {
            float angle = Random.Range(0, Mathf.PI * 2f);
            // calculate the spawn position based on the angle and radius
            Vector2 spawnPos = new Vector2(Mathf.Cos(angle) * radius, Mathf.Sin(angle) * radius);
            //Vector2 spawnPos = Random.insideUnitCircle*5;

            GameObject circleObj = Instantiate(circle, spawnPos, Quaternion.identity);
            circleObj.AddComponent<CircleCollider2D>();
            yield return new WaitForSeconds(ss);
        }
    }

}
