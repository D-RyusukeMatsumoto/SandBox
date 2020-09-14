﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    float speed = 0;


    // Start is called before the first frame update
    void Start()
    {
    }

    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x + Time.deltaTime * speed,
            transform.position.y,
            transform.position.z);    
    }
}