using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour
{

    public float distance = 1f;
    public LayerMask boxMask;
    GameObject box;

    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.queriesStartInColliders = false;
        float lookDirection = 1f;
        if (spriteRenderer.flipX)
        {
            lookDirection = -1f;
        }
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * lookDirection, distance, boxMask);


        if(hit.collider!= null && hit.collider.gameObject.tag=="pushable" && Input.GetKeyDown(KeyCode.E))
        {
            box = hit.collider.gameObject;

            box.GetComponent<FixedJoint2D>().enabled = true;
            box.GetComponent<BoxPull>().beingPushed = true;
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();

        } else if (Input.GetKeyUp(KeyCode.E))
        {
            box.GetComponent<FixedJoint2D>().enabled = false;

        }

    }

    private void OnDrawGizmos()
    {
        float lookDirection = 1f;
        if (spriteRenderer.flipX)
        {
            lookDirection = -1f;
        }

        Gizmos.color = Color.yellow;

        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * lookDirection * distance);
    }
}
