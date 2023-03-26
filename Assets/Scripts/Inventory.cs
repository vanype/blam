using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject[] slots;
    [SerializeField] GameObject totalItems;
    private void Start()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            slots[i].GetComponent<InventorySlot>().SetIndex(i+1);
        }
        //расставляет индексы каждому слоту
    }
    /*
        AddItem добавляет в первый незаполненный слот инвенторя предмет по ID, обращаяс к TotalItems
    */
    public void AddItem(int ID)
    {
        for (int i=0;i<slots.Length;i++)
        {
            if (!slots[i].GetComponent<InventorySlot>().GetFilledValue())
            {
                slots[i].GetComponent<InventorySlot>().Fill(ID,totalItems.GetComponent<TotalItems>().GetSprite(ID));
                break;
            }
        }
    }
    public bool CanAdd()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (!slots[i].GetComponent<InventorySlot>().GetFilledValue())
            {
                return true;
            }
        }
        return false;
    }
}
