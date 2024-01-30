using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObjectToInstanciate;
    IEnumerator WaitBetweenSpawns()
    {
        yield return new WaitForSeconds(3f);
        InstanciateGO();
    }
    public void InstanciateGO()
    {
        Vector3 position = new Vector3(0, 10, Random.Range(-5f, 5f));
        Instantiate(gameObjectToInstanciate, position, Quaternion.identity);
        StartCoroutine(WaitBetweenSpawns());
    }

}
