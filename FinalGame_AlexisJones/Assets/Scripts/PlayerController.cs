using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

   private Rigidbody rb;
    public GameObject ammo;
   Animator animator;
   public ParticleSystem ammoEffect;
   

    public float horizontalInput;
    public float verticalInput;
    public float speed;
    int isWalkingHash;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
       
        isWalkingHash = Animator.StringToHash("isWalking");
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        bool isWalking = animator.GetBool(isWalkingHash);
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            animator.SetBool(isWalkingHash, true);

        }
        if (isWalking && !Input.GetKey(KeyCode.A))
        {
            animator.SetBool(isWalkingHash, false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            animator.SetBool(isWalkingHash, true);
        }
        if (isWalking && !Input.GetKey(KeyCode.D))
        {
            animator.SetBool(isWalkingHash, false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
             animator.SetBool(isWalkingHash, true);

        }
        if(isWalking && !Input.GetKey(KeyCode.W))
        {
            animator.SetBool(isWalkingHash, false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
           animator.SetBool(isWalkingHash, true);
        }
        if (isWalking && !Input.GetKey(KeyCode.S))
        {
            animator.SetBool(isWalkingHash, false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ammo, transform.position + new Vector3(0.0f, 1f, 0.0f), transform.rotation);
            ammoEffect.Play();
        }

    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            FindObjectOfType<GameManager>().GameOver();
        }

    }

}
