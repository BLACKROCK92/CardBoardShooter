using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    public float fireRate = 0.5f;
    public float nextFire = 0.01f;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GetComponent<AudioSource>().Play();
        }
    }
}
