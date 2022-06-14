using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{
    public float moveSpeed;
    public float rotSpeed = 10f;
   private Rigidbody rigid;
    private GameObject player;
    private GameManager gameManager;
    private NavMeshAgent navMeshAgent;
    
  
    

    Animator animator;
    [SerializeField] private Transform movePositionTransform;
 
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    
    



    }
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination = movePositionTransform.position;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
      
          
            FindObjectOfType<GameManager>().GameOver();
           
        }
        if(collision.gameObject.tag == "WPN_cal_308")
        {
            gameManager.UpdateCounter(1);
            
        }
          
    }
   
}
