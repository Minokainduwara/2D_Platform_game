using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateBc : MonoBehaviour
{
    Material mat;
    Vector2 movement;
    public Vector2 speed;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        mat.mainTextureOffset = movement;
        movement += speed * Time.deltaTime;
    }
}
