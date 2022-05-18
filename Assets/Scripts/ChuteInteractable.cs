using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuteInteractable : MonoBehaviour
{
    [Tooltip("the object that will spawn when the player puts their hand in the collider")]
    public GameObject instanceObject;
    [Tooltip("the location the object will spawn from")]
    public GameObject spawnPoint;
    protected bool spawnObj = false;
    private bool canSpawn = true;

    void OnCollisionEnter()
    {
        if (canSpawn == true)
        {
            spawnObjectInChute();
            Debug.Log("Spawn Object Called");
            canSpawn = false;
            spawnObj = true;
        }
    }

    void spawnObjectInChute()
    {
        Instantiate(instanceObject, spawnPoint.transform.position, Quaternion.identity);
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
