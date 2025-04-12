using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Elements;

public class ProjectileScript : MonoBehaviour
{
    //[SerializeField] private float
    // Start is called before the first frame update
    [SerializeField] TipoElemento bulletElement;
    [SerializeField] private float damage;
    public AudioClip sonidoDisparo;



    void Start()
    {
        AudioManager.Instance.ReproducirSonido(sonidoDisparo);
        StartCoroutine(die());
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0, 1) * Time.deltaTime* GlobalVariables.Instance.projectileSpeed;
        // transform.Rotate(0, 1, 0);
    }
    IEnumerator die()
    {
        yield return new WaitForSeconds(GlobalVariables.Instance.projectileLifeTime);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        EnemyScript enemigo = collision.gameObject.GetComponent<EnemyScript>(); // no sé como acceder al elemento de otra manera
        Debug.Log(enemigo.element); // igual probablemente así es mejor pq así puedo cambiarle todas las weas
        enemigo.healthDown(bulletElement, damage);

        Destroy(gameObject);



    }
}
