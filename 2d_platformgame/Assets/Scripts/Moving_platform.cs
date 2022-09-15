using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_platform : MonoBehaviour
{
    Vector3 movement;
    public float speed;
    GameObject boundry;
    void Start()
    {
        movement.y = speed;
        boundry = GameObject.Find("Game_End");
    }

    // Update is called once per frame
    void Update()
    {
        movingplatform();
    }

    void movingplatform()
    {
        transform.position += movement * speed * Time.deltaTime;
        if (transform.position.y >= boundry.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
