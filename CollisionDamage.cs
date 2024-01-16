using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
    {
        [SerializeField] GameObject enemy;
    public int health = 1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Trigger");
            health--;
        }
        
    }
    void Update()
    {
        if (health <= 0){
        Die();
    }
    }
    void Die()
    {
        Destroy(enemy);
    }
    }
