using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Elements;

public class TornadoScript : MonoBehaviour
{
    [SerializeField] TipoElemento bulletElement;
    [SerializeField] private float damage;
    public AudioClip sonidoDisparo;


    [SerializeField] private float rotationSpeed;
    [SerializeField] private float pushForce;
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.ReproducirSonido(sonidoDisparo);
        StartCoroutine(die());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        transform.position = transform.position + new Vector3(0, 0, 1) * Time.deltaTime * GlobalVariables.Instance.projectileSpeed;

    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject theEnemy = collision.gameObject;
        EnemyScript enemigoScript = theEnemy.GetComponent<EnemyScript>();
        enemigoScript.healthDown(bulletElement, damage);

        Rigidbody rb = theEnemy.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 0, pushForce), ForceMode.Impulse);
    }
    IEnumerator die()
    {
        yield return new WaitForSeconds(GlobalVariables.Instance.projectileLifeTime);
        Destroy(gameObject);
    }
}
