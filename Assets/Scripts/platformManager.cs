using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformManager : MonoBehaviour
{
    public static platformManager Instance = null;

   [SerializeField]
    GameObject platformPrefab;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

        IEnumerator SpawnPlatform(Vector2 spawnPosition)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(platformPrefab, spawnPosition, platformPrefab.transform.rotation);
        }
    
}
