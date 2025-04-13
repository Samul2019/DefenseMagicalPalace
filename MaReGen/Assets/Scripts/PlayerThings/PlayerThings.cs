using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerThings : MonoBehaviour
{
    [SerializeField] private TMP_InputField InField;
    [SerializeField] private GameObject specialTooltip;
    [SerializeField] private bool specAvailable;

    #region gameobjects
    public ProjectilesHolderScript Projectiles;
    public SpecialProjectiles SpecProj;
    #endregion

    private List<string> LanesNames = new List<string> { "left", "center", "right" };

    // Start is called before the first frame update
    void Start()
    {
       /* Debug.Log("Vamos a imprimir las weas del diccionario");
        foreach (var kvp in Projectiles.projectilesDict)
        {
            Debug.Log("Clave: " + kvp.Key + ", GameObject: " + kvp.Value.name);
        }*/
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
        if(SpecProj.SpecialProjDict.ContainsKey(inp) && specAvailable ==true)
        {
            Instantiate(SpecProj.SpecialProjDict[inp], transform.position + Vector3.forward + Vector3.up, Quaternion.identity);
            StartCoroutine(specCDStart());
        }
    else if(SpecProj.SpecialProjDict.ContainsKey(inp) && specAvailable == false)
        {
            Debug.Log("Special ability in cd");
        }


    }

    IEnumerator specCDStart()
    {
        specAvailable = false;
        specialTooltip.gameObject.SetActive(false);
        yield return new WaitForSeconds(GlobalVariables.Instance.specialCD);
        specAvailable = true;
        specialTooltip.gameObject.SetActive(true);

    }
}
