using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileGun : MonoBehaviour
{
    [SerializeField] private GameObject ammo;
    [SerializeField] private Transform gunBarrel;
    [SerializeField] private float velocity;
    [SerializeField] private float shotDelay;
    [SerializeField] private bool fullyAuto;
    private float timer = 0;
    private bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

           if (!canShoot)
        {
            timer += Time.deltaTime;
        }
       if (!canShoot && (timer > shotDelay))
        {
            canShoot = true;
        }
       if (canShoot && (fullyAuto ? (Input.GetButton("Fire1")): (Input.GetButtonDown("Fire1"))))
        {
            canShoot = false;
            timer = 0;
            GameObject shot = GameObject.Instantiate(ammo, gunBarrel.position, Quaternion.identity);
            shot.GetComponent<Rigidbody>().AddForce(gunBarrel.forward * velocity, ForceMode.Impulse);
            shot.transform.Rotate(90, 0, 0);
        }
    }
}
