using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    public float amplitudeX, amplitudeZ, freqX, freqZ;
    Vector3 objectPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = amplitudeX * Mathf.Sin(freqX * Time.time);
        float z = amplitudeZ * Mathf.Cos(freqZ * Time.time);

        objectPosition = new Vector3(x, 0, z);

        transform.position = objectPosition;
    }
}
