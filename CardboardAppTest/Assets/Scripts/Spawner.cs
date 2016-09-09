using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public float startWait;
    public float waveWait;
    public float spawnWait;
    public int objectCount;
    public GameObject[] spawners = new GameObject[8];
    public GameObject objectPrefab;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < objectCount; i++)
            {
                Vector3 spawnPosition = spawners[Random.Range(0, 7)].transform.position;
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(objectPrefab, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}
