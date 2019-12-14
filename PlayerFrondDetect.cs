/*Integrantes: 
Ivaniel Díaz 
Edberg Mendez
Neriberto De Mera
Lía Valdés*/

//El codigo para dectar el objecto o cojerlo
//Asignar al Player 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PickUpObjects
public class PlayerFrondDetect : MonoBehaviour
{ 
    //Variable para Dectar al frente
    public GameObject ObjectFrond;//se utiliza para conectar ambos script

    //Variable para dectar arriba
    public GameObject ObjectHead;

    private void Update()
    {
        //dectada lo que esta al frende de el player
        if(ObjectFrond != null && ObjectFrond.GetComponent<ObjectFrond>().Detectado == true)
        {
            FindObjectOfType<PlayerController>().Jump();
        }

        //Dectar lo que esta arriba
        if(ObjectHead != null && ObjectHead.GetComponent<ObjectHead>().Detectado == true)
        {
            FindObjectOfType<PlayerController>().Slide(true);
        } 
        if(ObjectHead == null){
            FindObjectOfType<PlayerController>().Slide(false);
        }
                

    }

}
