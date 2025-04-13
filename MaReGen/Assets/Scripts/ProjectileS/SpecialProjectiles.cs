using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialProjectiles : MonoBehaviour
{

    [SerializeField] public List<GameObject> SpecialProjectilesObject = new List<GameObject>();
    [SerializeField] public List<string> projectilesName = new List<string>();

    public Dictionary<string, GameObject> SpecialProjDict = new Dictionary<string, GameObject>();

    private void Awake()
    {
        Debug.Log("IniciamosProcesoDeCombinarCosasEnDiccionario");
        Debug.Log("hay " + projectilesName.Count + " elementos");
        for (int i = 0; i < projectilesName.Count; i++)
        {
            SpecialProjDict.Add(projectilesName[i], SpecialProjectilesObject[i]);
        }
    }

    private void Start()
    {
        foreach (var kvp in SpecialProjDict)
        {
            Debug.Log("Clave: " + kvp.Key + ", GameObject: " + kvp.Value.name);
        }
    }
}
