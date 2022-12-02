﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{

    private Rigidbody2D myBody;

    [SerializeField]
    public float speed;

    // Start is called before the first frame update
    void Start(){
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D)){
            transform.position += transform.right * (Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A)){
            transform.position -= transform.right * (Time.deltaTime * speed);
        }
    }
}
