using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;

    public bool dialogActive;

    private string[] dialogLines;
    private int currentLine;

    public Dialog dialogScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!dialogActive) { return; }// Make sure this script does not try to show dialog while it shouldn't

        if(dialogActive && Input.GetKeyDown(KeyCode.F))
        {
            //dBox.SetActive(false);
            //dialogActive = false
            currentLine++;
            if (currentLine >= dialogLines.Length)
            {
                dBox.SetActive(false);
                dialogActive = false;
            }
            else
            {
                dialogScript.TypeSentence(dialogLines[currentLine]);
            }
        }

         
    }

    public void ShowBox(string dialogue)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialogue; 
    }

    public void ShowDialogue(string[] dialog)
    {
        dialogLines = dialog;
        currentLine = 0;
        dBox.SetActive(true);
        dialogScript.TypeSentence(dialogLines[currentLine]);// dit mag al wel meteen
        StartCoroutine(ActivateDialogAfterOneFrame());
    }

    private IEnumerator ActivateDialogAfterOneFrame()
    {
        yield return null;
        dialogActive = true;
    }
}
