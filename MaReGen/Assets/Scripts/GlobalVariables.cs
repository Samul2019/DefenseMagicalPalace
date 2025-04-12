using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public static GlobalVariables Instance;
    [SerializeField] public float projectileSpeed = 1;
    [SerializeField] public float projectileLifeTime = 1;

    #region PlayerLanes
    [SerializeField] public Vector3 leftLane;
    [SerializeField] public Vector3 rightLane;
    [SerializeField] public Vector3 centerLane;
    
    #endregion

    void Awake()
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
}
