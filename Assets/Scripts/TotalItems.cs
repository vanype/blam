using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalItems : MonoBehaviour
{
    [SerializeField]private GameObject[] itemsOBJ;
    [SerializeField]private Sprite[] itemsICO;
    
    public GameObject GetObject(int ID)
    {
        if(CheckIDCorrectness(ID))
        {
            return itemsOBJ[ID];
        }
        return null;
    }
    /*
    Все айтемы(предметы), их иконки хранятся в массивах, скрипт висит на пустом объекте на сцене
     */
    public Sprite GetSprite(int ID)
    {
        if (CheckIDCorrectness(ID))
        {
            return itemsICO[ID];
        }
        return null;
    }

    /*
      Теперь все действия предметов( у тех предметов, у которых они есть ) тоже хранятся здесь.
     
     */

    public void TryToDoAction(int ID, GameObject player, InventorySlot requesterSlot)
    {
        
        if (CheckIDCorrectness(ID))
        {
            //необязательный код, для удобства, что бы не перегружать строку
            Item thisItem = itemsOBJ[ID].GetComponent<Item>();
            Debug.Log("ID is correct");
            //проверка есть ли у айтема скрипт действия
            if (thisItem.GetActionHave() == true)
            {
                Debug.Log("This item have a action");
                DoActionByID(ID, player, requesterSlot);
            }
        }

    }
    //проверка айдишника, существует ли такой
    private bool CheckIDCorrectness(int ID)
    {
        return ID >= 0 && ID < itemsOBJ.Length;
    }
    private void DoActionByID(int ID, GameObject player, InventorySlot requesterSlot)
    {
        switch (ID)
        {
            case 0:
                player.GetComponent<PlayerHP>().HP_Update(4);
                requesterSlot.DeleteItem();
                Debug.Log("the action is done");
                break;
            case 1:
                player.GetComponent<PlayerHP>().HP_Update(15);
                requesterSlot.DeleteItem();
                Debug.Log("the action is done");
                break;
            case 2:
                player.GetComponent<PlayerHP>().HP_Update(-20);
                requesterSlot.DeleteItem();
                break;
                /*case itemID:
                         some action();
                      */
        }
    }
}
