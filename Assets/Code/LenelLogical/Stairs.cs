using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Enter in straits");
            collision.GetComponent<RunScript>().onStairs = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Exit from strits");
            collision.GetComponent<RunScript>().onStairs = false;
            collision.GetComponent<Player>().ExitStraits();
        }
    }
}
