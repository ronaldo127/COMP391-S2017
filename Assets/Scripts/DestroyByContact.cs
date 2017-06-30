using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boundery")) return;
        
        Destroy(other.gameObject);
        animator.SetTrigger("Explode");
    }

    public void DestroyMe()
    {
        Destroy(gameObject);
    }

}
