using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAmmoBehavior : MonoBehaviour
{

    [SerializeField] private float deathTime = 2f;
    [SerializeField] private int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, deathTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        health hp = collision.gameObject.GetComponent<health>();
        if (hp != null)
        {
            hp.takeDamage(damage);
        }
        Destroy(gameObject);
    }
}
