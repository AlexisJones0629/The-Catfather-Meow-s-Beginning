using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 30.0f;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy"){
           
            Destroy(gameObject);
            Destroy(other.gameObject);
           
        }
      
    }
}
