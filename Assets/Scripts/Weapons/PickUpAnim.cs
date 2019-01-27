﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAnim : MonoBehaviour
{
    [SerializeField] private float ang = 1f;
    [SerializeField] private float scl = 0.01f;
    [SerializeField] private float max = 1.4f;
    [SerializeField] private float min = 0.6f;

    private bool grow = false;
    
    void FixedUpdate()
    {
        if (transform.localScale.x > max)
            grow = true;
        else if (transform.localScale.x < min)
            grow = false;
        
        transform.Rotate(Vector3.up, ang);
        
        if (!grow)
        {
            transform.localScale = new Vector3(transform.localScale.x+scl, transform.localScale.y+scl,transform.localScale.z+scl);
        }
        else
        {
            transform.localScale = new Vector3(transform.localScale.x-scl, transform.localScale.y-scl,transform.localScale.z-scl);
        }
    }
}
