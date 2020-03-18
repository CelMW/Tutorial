using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    private bool cogido = false;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cogido)
        {
           transform.position = player.GetComponent<Movimiento>().get_socket();
            if (Input.GetKeyDown(KeyCode.Q)){
                cogido = false;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!cogido) { 
           if ((collision.tag.Equals("Player"))&& (Input.GetKeyDown(KeyCode.E)))
        {
            cogido = true;
            transform.position = collision.GetComponent<Movimiento>().get_socket();
            player = collision.gameObject;
        }
    }
    }
   
}
