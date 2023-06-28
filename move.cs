using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class move : MonoBehaviour
{
    //THIS IS FOR EVERY SINGLE BLOB NOT THE WHOLE GAME

    // Set the radius of the circle sprite
    public float radius = 1f;
    // Set the target position for the circle sprite
    public Vector3 targetPos = new Vector3(0f, 0f, 0f);

    //makes sure the hit happened and no duplicates, timeAlive is how long each blob survives
    private bool hit = false;
    public float timeAlive = 0f;


    //time that judges whether the hit is in the corner or not using timeAlive comparison
    public float timeTillHit = 0f;


    // Update is called once per frame
    void Update()
    {
        //Calculate the distance between the current position and the target position
        Vector3 distance = targetPos - transform.position;

        //Calculate the direction towards the target position
        Vector3 direction = distance.normalized;

        //Move the circle sprite towards the target position
        transform.position += direction * triangle.speed * Time.deltaTime;

        timeAlive += Time.deltaTime;

        //for mode 2, where the speed gradually increases
        if (HOME.mode == 2)
        {
            triangle.speed += 0.0002f;
            Circle.ss = Circle.ss - 0.00005f;
        }
        else if(HOME.mode == 0)
        {
            triangle.speed += 0.0002f;
            Circle.ss = Circle.ss - 0.00005f;
        }
        //was 2.15
        //
        timeTillHit = 2.03f / triangle.speed;
    }

    //when the blob hits the middle shape
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && !hit)
        {

            hit = true;
            Debug.Log(triangle.speed + ", timeAlive: " + timeAlive +", TimetillHit: "+ timeTillHit);
            if (timeAlive > timeTillHit)
            {
                triangle.score += 1;
            }
            else
            {
                triangle.lives -= 1;
            }
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (HOME.mode == 0)
        {
            Camera.main.backgroundColor = new Color(49f / 255f, 77f / 255f, 121f / 255f);
            triangle.speed = 1f;
            Circle.ss = 0.5f;           

        }
        else if (HOME.mode == 1)
        {
            Camera.main.backgroundColor = new Color(158f / 255f, 6f / 255f, 6f / 255f);
            triangle.speed = 2f;
            Circle.ss = 0.5f;
        }
        else if (HOME.mode == 2)
        {
            Camera.main.backgroundColor = new Color(1f / 255f, 130f / 255f, 40f / 255f);
        }
        Circle.tsec = 0f;
    }
}
