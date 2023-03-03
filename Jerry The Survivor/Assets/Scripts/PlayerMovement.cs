using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public int Speed;


    // Update is called once per frame
    void Update()
    {
        //player movement with keyboard

        //w = move forward
        if(Input.GetKey(KeyCode.W)){ transform.Translate(Vector3.forward * Speed * Time.deltaTime); }

        //s = move backward
        if(Input.GetKey(KeyCode.S)){ transform.Translate(Vector3.back * Speed * Time.deltaTime); }

        //a = move left
        if(Input.GetKey(KeyCode.A)){ transform.Translate(Vector3.left * Speed * Time.deltaTime); }

        //d = move right
        if(Input.GetKey(KeyCode.D)){ transform.Translate(Vector3.right * Speed * Time.deltaTime); }
    }
}
