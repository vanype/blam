using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    private Animator inv_Animator;
    private bool inv_Opened;
    private void Start()
    {
        inv_Animator = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Animator>();
    }
    private void Update()
    {
        //открытие инвентаря
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!inv_Opened)
            {
                inv_Animator.SetTrigger("InvOpen");
                inv_Opened = true;
            }
            else
            {
                inv_Animator.SetTrigger("InvClose");
                inv_Opened = false;
            }
        }
    }
}
