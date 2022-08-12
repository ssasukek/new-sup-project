using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public AudioSource attackSound;
    public Animator ZombieAnimations;
    // Start is called before the first frame update
    void Start()
    {
        ZombieAnimations=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter (Collider other){
        Debug.Log("attack");
        ZombieAnimations.SetBool("IsRunning", false);
        ZombieAnimations.SetTrigger("DoAttack");
        attackSound.Play();
        
    }
}
