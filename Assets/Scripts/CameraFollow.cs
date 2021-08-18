using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float speed;

    void Update(){
        float pPosX = player.transform.position.x;
        float cPosX = transform.position.x;
        if(pPosX-cPosX > 3){
            transform.position = new Vector3(cPosX+speed,transform.position.y,transform.position.z);
        }
        if(pPosX-cPosX < -3){
            transform.position = new Vector3(cPosX-speed,transform.position.y,transform.position.z);
        }

        float pPosY = player.transform.position.y;
        float cPosY = transform.position.y;
        if(pPosY-cPosY > 3){
            transform.position = new Vector3(transform.position.x,cPosY+speed,transform.position.z);
        }
        if(pPosY-cPosY < -3){
            transform.position = new Vector3(transform.position.x,cPosY-speed,transform.position.z);
        }
    }
}
