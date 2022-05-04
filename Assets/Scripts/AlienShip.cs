using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienShip : MonoBehaviour
{
    public GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        gameController.OnShipDestroyed();
        GameObject.Destroy(other.gameObject);
        GameObject.Destroy(gameObject);
    }
}
