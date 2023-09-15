using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour{

    [SerializeField] float Speed;
    
    void Update(){
        transform.Translate(Vector3.right * Time.deltaTime * Speed);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        Destroy(gameObject);
    }
}
