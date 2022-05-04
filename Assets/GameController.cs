using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int NumberOfShips;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnShipDestroyed()
    {
        if (--NumberOfShips == 0)
        {
            Debug.Log("Bravo!");
        }
        else
        {
            Debug.Log($"Il reste {NumberOfShips} vaisseaux.");
        }
    }
}
