using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //object Collision
    void OnTriggerEnter(Collider other){
        if(other.tag == "object"){
            ScoreManager.instance.AddScore(10);
            Destroy(other.gameObject);
        }
    }
}
