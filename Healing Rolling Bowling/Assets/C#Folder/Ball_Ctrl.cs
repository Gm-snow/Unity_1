using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Ctrl : MonoBehaviour
{

    float movespeed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance_per_frame = movespeed * Time.deltaTime;

        
        float horizontal = Input.GetAxis("Horizontal");

        
        this.transform.Translate(Vector3.right * horizontal * distance_per_frame);

    }
}
