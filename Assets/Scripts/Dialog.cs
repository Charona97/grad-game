using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public Text textDisplay;
    public float typingSpeed = 0.01f;

    public bool continueDialogue = true;
    private float timer;
    public float timerTime;
    
    public int progressNum;
    
    IEnumerator Type(string sentence) {
        foreach (char letter in sentence)
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void TypeSentence(string sentence)
    {
        StopAllCoroutines();// hiermee stopt hij het typen van de vorige mogelijke zinnen
        textDisplay.text = "";
        StartCoroutine(Type(sentence));
    }
}

