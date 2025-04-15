using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static Elements;

public class EnemyScript : MonoBehaviour
{

    [SerializeField] private float minSpeed,maxSpeed;

    [SerializeField] public float speed;
    [SerializeField] private float maxHealth;
    [SerializeField] public float health;

    [SerializeField] public TipoElemento element;

    [SerializeField] private TipoElemento weakness;

    [SerializeField] private GameObject damageCanvas;
    [SerializeField] private TMP_Text damageText;

    [SerializeField] public AudioClip deathAudio;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        speed = Random.Range(minSpeed,maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, GlobalVariables.Instance.centerLane, speed*Time.deltaTime);
        transform.position = transform.position + new Vector3 (0,0,-1*speed*Time.deltaTime);
    }

    public void healthDown(TipoElemento bulletElement, float damage)
    {
        damageText.text = damage.ToString();
        damageCanvas.gameObject.SetActive(true);

        if (bulletElement == weakness)
        {
            health -= damage*2;
        }else
        {
            health -= damage;
        }
        if (health <= 0)
        {
            die();
        }
    }
    private void die()
    {
        AudioManager.Instance.ReproducirSonido(deathAudio);
        damageCanvas.gameObject.SetActive(false);
        health = maxHealth;
        gameObject.SetActive(false);
    }
}
