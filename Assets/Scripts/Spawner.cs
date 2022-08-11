using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    private GameObject lastGO;

    public void RespawnObject()
    {
        Destroy(lastGO);
        lastGO = Instantiate(ObjectToSpawn);
    }
}
