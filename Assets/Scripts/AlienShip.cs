using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AlienShip : MonoBehaviour
{
    public UnityEvent borderReachedEvent, shipDestroyedEvent;

    private float shipSpeed = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(shipSpeed * Time.deltaTime, 0, 0);
        if (Mathf.Abs(transform.position.x) > 10)
        {
            //transform.Translate(0, -1, 0);
            //shipSpeed = -shipSpeed;
            Debug.Log($"Ship {name} detected borderReachedEvent");
            borderReachedEvent.Invoke();
        }
    }

    public void Descend()
    {
        transform.Translate(0, -1, 0);
        shipSpeed = -shipSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        GameObject.Destroy(other.gameObject);
        GameObject.Destroy(gameObject);
        shipDestroyedEvent.Invoke();
    }
}
