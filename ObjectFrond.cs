/*Integrantes: 
Ivaniel Díaz 
Edberg Mendez
Neriberto De Mera
Lía Valdés*/
//Codigo Para el Objecto que queramos tectar/para los objectos que queremos cojer
//Asignar al Objecto
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PickableObject
public class ObjectFrond : MonoBehaviour
{
    public bool Detectado = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "InterZone")//el objecto decta el tag del player
        {
            other.GetComponentInParent<PlayerFrondDetect>().ObjectFrond = this.gameObject;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "InterZone")
        {
            other.GetComponentInParent<PlayerFrondDetect>().ObjectFrond = null;
        }
    }

}
