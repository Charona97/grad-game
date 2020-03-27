using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{

 
    private Movement player;
    public GameObject lootDrop;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
    
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.Damage(100);
        }
    }

    
}
