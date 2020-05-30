using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpBalloon : MonoBehaviour
{
    [SerializeField] private Image customImage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            customImage.enabled = true;
        }
    }

     private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            customImage.enabled = false;
        }
    }

}
