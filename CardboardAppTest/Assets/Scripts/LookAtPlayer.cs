using System;
using UnityEngine;


public class LookAtPlayer : MonoBehaviour
{
    public Transform target;
    public GameObject playerRef;

    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("MainCamera");
        target = playerRef.transform;
    }

    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target);
        }
    }

}