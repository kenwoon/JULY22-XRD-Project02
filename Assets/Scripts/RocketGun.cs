using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketGun : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private Transform spawnPoint;

    [SerializeField]
    private float shootForce;

    [SerializeField]
    private AudioSource bulletAudioPlayer;

    [SerializeField]
    private AudioClip bulletClip;

    private GameObject tempBullet;

    /// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Create a bullet
            tempBullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);

            // Play the bullet sound
            bulletAudioPlayer.PlayOneShot(bulletClip);

            // Get Rigid Body component and add forward force to it
            tempBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shootForce);

            Destroy(tempBullet, 5);
        }
    }
}
