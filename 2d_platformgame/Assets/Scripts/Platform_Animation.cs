using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Animation : MonoBehaviour
{
    private Animator _fananim;
    void Start()
    {
        _fananim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            _fananim.Play("Fan_On");
        }
    }
}
