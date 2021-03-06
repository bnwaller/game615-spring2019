﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections; 

public class PlanePilot : MonoBehaviour 
{
    public float speed = 90.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() 
    { 
       
        transform.position += transform.forward * Time.deltaTime * speed;

        speed -= transform.forward.y * Time.deltaTime * 40.0f;

        if(speed < 35.0f) 
        {
            speed = 35.0f;
        }

        transform.Rotate( Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight( transform.position );

        if(terrainHeightWhereWeAre > transform.position.y) 
        {
            transform.position = new Vector3(transform.position.x,
                                              terrainHeightWhereWeAre,
                                              transform.position.z);
        }
    }
}
