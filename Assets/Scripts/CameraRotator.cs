using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public float speed;
    public bool rotate = true;


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    rotate = !rotate;

        //}

        //if (rotate)
        //{
            transform.Rotate(0, speed * Time.deltaTime, 0);
        //}
        
    }
}
