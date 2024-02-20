using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource jumpSfx;

     void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpSfx.Play();
        } 
    }
}
