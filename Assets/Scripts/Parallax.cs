using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform cam;
    public float relativeMove = .3f;
    public Vector3 startpos;

    private void Start()
    {
        startpos = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(startpos.x + cam.position.x * relativeMove, startpos.y + cam.position.y * relativeMove);
    }
}
