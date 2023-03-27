using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int ID;

    //указывает на то, можно ли с предметом совершить действие, нажав на него в инвентаре 
    [SerializeField] private bool haveAction;

    private IEnumerator cour;
    private bool canPick;
    private Inventory inventory;
    private ItemActions itemActions;

    private void Start()
    {
        itemActions = GameObject.FindGameObjectWithTag("ItemActions").GetComponent<ItemActions>();
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
    }


    public int GetID()
    {
        return ID;
    }

    public bool GetActionHave()
    {
        return haveAction;
    }



    /*
        содержит проблемную часть, которую нужно будет заменить
        функция Delay() нужна, что бы создать задержку перед поднятием предмета 
    */



    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            canPick = true;
            StartCoroutine(Delay());
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            canPick = false;
        }
    }    

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        if (inventory.CanAdd() && canPick)
        {
            inventory.AddItem(ID);
            Destroy(gameObject);
        }
    }
}
