using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Fields

    // References
    Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    public void ToggleOpenDoor()
    {
        Debug.Log("Toggling door open/closed!");
        animator.SetTrigger("Open");
    }
}