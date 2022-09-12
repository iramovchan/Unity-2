using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float downBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // destroy sandwich when out of screen
        // destroy animal when out of screen
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < downBound)
        {
            Debug.Log("Game over.");
            Destroy(gameObject);   
        }
    }
}
