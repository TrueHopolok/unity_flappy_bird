using UnityEngine;

public class TubeSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] tubePrefabs;
    [SerializeField] float verticalSpread = 2f;
    [SerializeField] float targetSpawnTime = 2f;
    float timeSinceLastSpawn = 0f;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= targetSpawnTime)
        {
            timeSinceLastSpawn = 0f;
            GameObject inst = Instantiate(tubePrefabs[Random.Range(0, tubePrefabs.Length)]);
            float verticalOffset = Random.Range(-verticalSpread, verticalSpread);
            inst.transform.position = transform.position + new Vector3(0, verticalOffset, 0);
        }
    }
}
