using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public float startWait;
    public float waveWait;
    public float spawnWait;
    public int objectCount;
    public GameObject[] spawners = new GameObject[14];
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
                Vector3 spawnPosition = spawners[Random.Range(0, spawners.Length)].transform.position;
                Quaternion spawnRotation = new Quaternion();
                spawnRotation.Set(-90, 0, 0,0);
                Instantiate(objectPrefab, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}
