using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoScript : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float pushForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Rigidbody enemigo = collision.gameObject.GetComponent<Rigidbody>(); // no sé como acceder al elemento de otra manera
        //Debug.Log(enemigo.element); // igual probablemente así es mejor pq así puedo cambiarle todas las weas
        //enemigo.AddForce(new Vector3 (0, 0, pushForce), ForceMode.Impulse);
        //Destroy(gameObject);
        collision.gameObject.transform.position = Vector3.MoveTowards(collision.gameObject.transform.position, collision.gameObject.transform.position+ new Vector3(0, 0, pushForce),pushForce);
    }
}
