using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movebytouch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* if (Input.touchCount > 0)
         {
             Touch touch = Input.GetTouch(0);
             Vector3 touchposition = Camera.main.ScreenToWorldPoint(touch.position);
             touchposition.z = 0f;
             transform.position = touchposition;

         }
        */

        //To show all the touches on screen

        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 touchposition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero, touchposition, Color.white);
        }
    }
}
