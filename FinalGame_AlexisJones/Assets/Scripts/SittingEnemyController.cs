using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SittingEnemyController : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Destroy(collision.gameObject);
            FindObjectOfType<GameManager>().GameOver();
        }
        if (collision.gameObject.tag == "WPN_cal_308")
        {
            gameManager.UpdateCounter(1);
        }

    }
}
