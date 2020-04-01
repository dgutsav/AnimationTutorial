using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeanimationcontroller : MonoBehaviour
{
    private bool isAnimating = false;
    private Animator animator;
    void Start(){
        animator = GetComponent<Animator>();
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            if(isAnimating){
                animator.SetBool("inAnimation", false);
                isAnimating = false;
            }
            else{
                isAnimating = true;
                animator.SetBool("inAnimation",true);
            }
        }
    }
}
