using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemySpawner : MonoBehaviour
{
    private float minEnemySpawnCD;
    private float maxEnemySpawnCD;
    private float cd;


    // Start is called before the first frame update
    void Start()
    {
        minEnemySpawnCD = EnemyGlobalVariables.Instance.minEnemySpawnCD;
        maxEnemySpawnCD = EnemyGlobalVariables.Instance.maxEnemySpawnCD;
        StartCoroutine(SpawnEnemies());
    }
    IEnumerator SpawnEnemies()
    {
        while (true)
        {

            //Instantiate(AllEnemies[CurrentEnemyIndex], transform.position, Quaternion.identity);
            GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = transform.position;
                //bullet.transform.rotation = bullet.transform.rotation;
                bullet.SetActive(true);
            }
            cd = Random.Range(minEnemySpawnCD, maxEnemySpawnCD);
            yield return new WaitForSeconds(cd);
        }
    }
}
