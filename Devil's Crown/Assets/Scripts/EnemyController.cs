using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour{
    [SerializeField] float Speed;
    GameObject Player;
    bool isAlive = true; 

    void Start(){
        Player = GameObject.FindGameObjectWithTag("Player"); 
    }

    // Update is called once per frame
    void Update(){
        if (Player != null && isAlive == true){
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, Speed * Time.deltaTime);
        }        
    }

   private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Bullet")){
            isAlive = false;
            Destroy(gameObject);
        }
    }
}
