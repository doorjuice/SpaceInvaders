using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMovement : MonoBehaviour
{
    public float missileSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, Time.deltaTime * missileSpeed, 0);
    }
}
