using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGlobalVariables : MonoBehaviour
{
    public static EnemyGlobalVariables Instance;



    [SerializeField] public float minEnemySpawnCD, maxEnemySpawnCD;



    public void Awake()
    {
        // Verificar si ya existe una instancia
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // No destruir al cambiar de escena
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
