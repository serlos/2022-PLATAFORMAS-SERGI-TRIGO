using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class Victoria : MonoBehaviour
{
    public GameObject InterfazVictoria;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
            InterfazVictoria.SetActive(true);


        }
    }
}