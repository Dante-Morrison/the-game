using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuteInteractable : MonoBehaviour
{
    protected bool spawnObj = false;
    private bool canSpawn = true;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        if (canSpawn == true)
        {
            canSpawn = false;
            spawnObj = true;
        }
    }

    IEnumerator objectSpawnCooldown() 
    {
        if (spawnObj == true)
        {
            spawnObj = false;
            yield return new WaitForSeconds(5);
            canSpawn = true;

        }
    }
}
