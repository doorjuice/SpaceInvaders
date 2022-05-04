using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 1f;
    public GameObject missile;

    private AlienShip[] AlienShips;

    // Start is called before the first frame update
    void Start()
    {
        AlienShips = FindObjectsOfType<AlienShip>();
        foreach (var ship in AlienShips)
        {
            Debug.Log($"Listening to {ship.name}.");
            ship.shipDestroyedEvent.AddListener(OnShipDestroyed);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed, 0, 0);
        if (Input.GetKeyDown("space"))
            Instantiate<GameObject>(missile, transform.position, Quaternion.identity);
    }

    public void OnShipDestroyed()
    {
        movementSpeed *= 1.5f;
    }
}
