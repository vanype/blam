using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovie : MonoBehaviour
{
    [SerializeField] private bool searchInStart;
    private Transform player;

    private void Start()
    {
        if (searchInStart)
        {
            searchPlayer();
        }
        
    }

    public void searchPlayer()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        Vector3 transformPlayer = new Vector3(0, 0, -10) + player.position;
        transform.position = Vector3.Lerp(transform.position, transformPlayer, 4f * Time.deltaTime);
    }
}
