using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("asteroid"))
        {
            // Destroy collided object
            Destroy(col.gameObject);
        }

        // Destroy bullet
        Destroy(gameObject);
    }
}
