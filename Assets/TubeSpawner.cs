using UnityEngine;

public class TubeSpawner : MonoBehaviour
{
    [SerializeField] GameObject tubePrefab;
    [SerializeField] float verticalSpread = 2f;
    [SerializeField] float targetSpawnTime = 2f;
    float timeSinceLastSpawn = 0f;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= targetSpawnTime)
        {
            timeSinceLastSpawn = 0f;
            GameObject inst = Instantiate(tubePrefab);
            float verticalOffset = Random.Range(-verticalSpread, verticalSpread);
            inst.transform.position = transform.position + new Vector3(0, verticalOffset, 0);
        }
    }
}
