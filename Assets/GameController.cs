using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private AlienShip[] AlienShips;

    // Start is called before the first frame update
    void Start()
    {
        AlienShips = FindObjectsOfType<AlienShip>();
        foreach (var ship in AlienShips)
        {
            Debug.Log($"Listening to {ship.name}.");
            ship.borderReachedEvent.AddListener(OnBorderReached);
            ship.shipDestroyedEvent.AddListener(OnShipDestroyed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBorderReached() {
        Debug.Log($"Event BorderReached received.");
        foreach (var ship in AlienShips) {
            ship.Descend();
        }
    }

    public void OnShipDestroyed()
    {
        AlienShips = FindObjectsOfType<AlienShip>();
        if (AlienShips.Length == 0)
        {
            Debug.Log("Bravo!");
        }
        else
        {
            Debug.Log($"Il reste {AlienShips.Length} vaisseaux.");
        }
    }
}
