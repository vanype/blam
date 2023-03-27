using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    private Inventory inventory;
    private Animator inv_Animator;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
        inventory.SetPlayerObject(gameObject);
        inv_Animator = inventory.gameObject.GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            inv_Animator.SetTrigger("InventoryAction");
        }
    }
    
}
