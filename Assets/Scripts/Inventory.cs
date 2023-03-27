using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject[] slots;
    [SerializeField] private GameObject totalItems;
    private GameObject player;
    
    private void Start()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].GetComponent<InventorySlot>().SetIndex(i + 1);
        }
        
        //расставляет индексы каждому слоту
    }
    
    
    //устанавливаем ссылку на игрока
    public void SetPlayerObject(GameObject _player)
    {
        player = _player;
    }
    //получаем ссылку на игрока
    public GameObject GetPlayerObject()
    {
        return player;
    }


    /*
        AddItem добавляет в первый незаполненный слот инвенторя предмет по ID, обращаяс к TotalItems
    */

    public void AddItem(int ID)
    {
        for (int i=0;i<slots.Length;i++)
        {
            if (slots[i].GetComponent<InventorySlot>().GetFilledValue() == false)
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
            if (slots[i].GetComponent<InventorySlot>().GetFilledValue() == false)
            {
                return true;
            }
        }
        return false;
    }
}
