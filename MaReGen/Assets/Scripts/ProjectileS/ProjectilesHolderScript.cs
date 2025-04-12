using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ProjectilesHolderScript : MonoBehaviour
{
    [SerializeField] public List<GameObject> projectilesObject = new List<GameObject>();
    [SerializeField] public List<string> projectilesName = new List<string>();
    public Dictionary<string, GameObject> projectilesDict = new Dictionary<string, GameObject>();

    public void Awake()
    {
        
            Debug.Log("IniciamosProcesoDeCombinarCosasEnDiccionario");
            Debug.Log("hay " + projectilesName.Count + " elementos");
            // Llenamos el diccionario con los elementos de las listas
            for (int i = 0; i < projectilesName.Count; i++)
            {
                projectilesDict.Add(projectilesName[i], projectilesObject[i]);
            }
        }
    public void Start() { 


        // Imprimir el contenido del diccionario
       /* foreach (var kvp in projectilesDict)
        {
            Debug.Log("Clave: " + kvp.Key + ", GameObject: " + kvp.Value.name);
        }*/
    }
}
