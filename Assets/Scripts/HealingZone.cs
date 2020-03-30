using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingZone : MonoBehaviour
{
    public float regenerateTime = 1f;
    public int healthBoost = 10;

    private void OnTriggerEnter2D(Collider2D col)
    {
        Movement healthScript = col.GetComponent<Movement>();

        if (col.gameObject.name.Equals("Player") && healthScript.curHealth < healthScript.maxHealth) 
            StartCoroutine(Heal(healthScript));
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
            StopAllCoroutines();
    }

    IEnumerator Heal(Movement healthScript)
    {
        while (healthScript.curHealth < healthScript.maxHealth)
        {
            yield return new WaitForSeconds(regenerateTime);
            healthScript.Heal(healthBoost);
            
        }
    }
}
