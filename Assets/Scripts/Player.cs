using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        //Entradas de teclado
        if (Input.GetKeyDown(KeyCode.D)){
            //Indicamos que es lo que vamos a cambiar
            animator.SetBool("isWalkL", true);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.D)){
            animator.SetBool("isWalkL", false);
        }
        if (Input.GetKeyDown(KeyCode.A)){
            //Indicamos que es loq ue vamos a cambiar
            animator.SetBool("isWalkL", true);
            //Indicamos que al ir a otro lado se va a girar
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKeyUp(KeyCode.A)){
            animator.SetBool("isWalkL", false);
        }
        if (Input.GetKeyDown(KeyCode.W)){
            animator.SetBool("isWalkV", true);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.W)){
            animator.SetBool("isWalkV", false);
        }
        if (Input.GetKeyDown(KeyCode.S)){
            animator.SetBool("isWalkV", true);
            transform.localRotation = Quaternion.Euler(180, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.S)){
            animator.SetBool("isWalkV", false);
        }
    }
}
