using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlatforms : MonoBehaviour
{
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            platformManager.Instance.StartCoroutine("SpawnPlatform", new Vector2(transform.position.x, transform.position.y));
            Invoke("DropPlatform", 3f);
            Destroy(gameObject, 1f);
        }
    }

    void DropPlatform()
    {
        rb.isKinematic = false;
    }
}
