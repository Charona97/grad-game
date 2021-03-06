﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogHolder : MonoBehaviour
{

    public string dialogue;
    private DialogueManager dMan;

    public string[] dialogueLines;
    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
    }

    private void OnTriggerStay2D (Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.F))
            {
                //dMan.ShowBox(dialogue);

                if (!dMan.dialogActive)
                {
                    dMan.ShowDialogue(dialogueLines);
                }
            }
        }
    }
}
