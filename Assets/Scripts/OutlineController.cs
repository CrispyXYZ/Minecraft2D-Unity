using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3((int)Math.Round(pos.x),(int)Math.Round(pos.y),0);
        if(Input.GetMouseButton(0)) ObjectCreator.RemoveObject(transform.position);
        if(Input.GetMouseButton(1)) ObjectCreator.CreateObject(transform.position);
    }
}
