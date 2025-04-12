using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerThings : MonoBehaviour
{
    [SerializeField] private TMP_InputField InField;


    #region gameobjects
    public ProjectilesHolderScript Projectiles;
    #endregion

    private List<string> LanesNames = new List<string> { "left", "center", "right" };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Vamos a imprimir las weas del diccionario");
        foreach (var kvp in Projectiles.projectilesDict)
        {
            Debug.Log("Clave: " + kvp.Key + ", GameObject: " + kvp.Value.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            shoot(InField.text.ToLower());

            InField.text = null;
            InField.Select();
            InField.ActivateInputField();

        }
    }

    private void shoot(string inp)
    {
        if (LanesNames.Contains(inp))
        {
            if (inp == "center")
            {
                transform.position = GlobalVariables.Instance.centerLane;
            }

            if (inp == "left")
            {
                transform.position = GlobalVariables.Instance.leftLane;
            }

            if (inp == "right")
            {
                transform.position = GlobalVariables.Instance.rightLane;
            }
        }
        else
        {
            if (Projectiles.projectilesDict.ContainsKey(inp))
            {
                Instantiate(Projectiles.projectilesDict[inp], transform.position + Vector3.forward+Vector3.up, Quaternion.identity);

            }
            else
            {
                Debug.Log("No existe ese poder"); //hacer un pop up ingame que diga eso
            }
        }



    }
}
