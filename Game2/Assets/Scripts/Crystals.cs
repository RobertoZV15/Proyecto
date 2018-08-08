using UnityEngine;
using System.Collections;

public class Crystals : MonoBehaviour
{

    private Controls player;
    public AudioSource bling;

    void Start()
    {
        player = FindObjectOfType<Controls>();
    }

    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            bling.Play();
            player.crystals++;
        }
    }
}
