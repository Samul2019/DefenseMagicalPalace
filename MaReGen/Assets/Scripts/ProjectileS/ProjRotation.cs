using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjRotation : MonoBehaviour
{
    [SerializeField] private float rotationX;
    [SerializeField] private float rotationY;
    [SerializeField] private float rotationZ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationX * Time.deltaTime, rotationY*Time.deltaTime, rotationZ*Time.deltaTime);

    }
}
