using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float velocidad = 0.1f;
    public bool tonta;
    public GameObject socket;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movx = Input.GetAxis("Horizontal")*velocidad + transform.position.x;
        float movy = Input.GetAxis("Vertical") * velocidad + transform.position.y;
        transform.position = new Vector2(movx, movy);
      
       
    }
   public Vector2 get_socket()
    {
        return socket.transform.position;
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        //barco -> tiene una clase que se llama set_pasajero(gameobject)
        //disparo tiene una referencia al arma del que ha salido
        if (collision.tag.Equals("Barco"))
        {
            collision.GetComponent<Barco>().set_pasajero(this);
        }
        if (collision.tag.Equals("Disparo_enemigo"))
        {
            GameObject aux= collision.GetComponent<Disparo>().get_arma();
            vida= vida - aux.GetComponent<Arma>.get_daño();

        }
    } */
}
