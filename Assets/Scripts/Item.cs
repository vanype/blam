using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private IEnumerator cour;
    [SerializeField]private int ID;

    public int GetID()
    {
        return ID;
    }
    

    /*
        содержит проблемную часть, которую нужно будет заменить
        функция delay нужна, что бы создать задержку перед поднятием предмета 
    */



    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().CanAdd())
            {
                cour = delay();
                StartCoroutine(cour);
                Debug.Log("CoroutineStarted");
            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (cour != null)
            {
                StopCoroutine(cour);
            }
            
            Debug.Log("CoroutineStoped");
        }
    }


    private IEnumerator delay()
    {
        yield return new WaitForSeconds(1);
        if (GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().CanAdd())
        {
            GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().AddItem(ID);
            Destroy(gameObject);
        }
    }
}
