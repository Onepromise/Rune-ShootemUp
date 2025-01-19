using UnityEngine;

public class Level1Manager : MonoBehaviour
{

    public GameObject[] enemies;

    [SerializeField] private float spawnInterval = 5f;
    [SerializeField] private float spawnRadius = 10f;
    [SerializeField] private Transform target;
    

    // Update is called once per frame
    void Update()
    {
        //spawn the enemy based on spawn interval
        spawnInterval -= Time.deltaTime;
        if(spawnInterval <=0)
        {
            SpawnEnemy();
            spawnInterval = Random.Range(1,3);
        }    
    }

    private void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, enemies.Length);


        // Calculate a random spawn position within the spawn radius
        Vector3 spawnPosition = target.position + Random.insideUnitSphere * spawnRadius;
        spawnPosition.y = 1f;

        GameObject enemy = Instantiate(enemies[enemyIndex], spawnPosition, Quaternion.identity);
      
    }
    
}
