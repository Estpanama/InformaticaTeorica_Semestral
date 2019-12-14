/*Integrantes: 
Ivaniel Díaz 
Edberg Mendez
Neriberto De Mera
Lía Valdés*/

//Asignar al Objecto
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PickableObject
public class ObjectHead : MonoBehaviour
{
    public bool Detectado = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "InterZone")//el objecto decta el tag del player
        {
            other.GetComponentInParent<PlayerFrondDetect>().ObjectHead = this.gameObject;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "InterZone")
        {
            other.GetComponentInParent<PlayerFrondDetect>().ObjectHead = null;
        }
    }
}
