using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator
{
    private static Dictionary<Vector3,GameObject> blocks = new Dictionary<Vector3,GameObject>();

    public static void CreateObject(Vector3 position){
        CreateObject(position, Guid.NewGuid().ToString());
    }

    public static void CreateObject(Vector3 position, string name) {
        if(blocks.ContainsKey(position)) return;
        GameObject obj = new GameObject();
        obj.name = name;
        obj.AddComponent<SpriteRenderer>();
        obj.AddComponent<BoxCollider2D>();
        obj.GetComponent<SpriteRenderer>().sprite = Resources.Load("planks", typeof(Sprite)) as Sprite;
        obj.GetComponent<BoxCollider2D>().size = new Vector2(1,1);
        obj.transform.position = position;
        blocks.Add(position, obj);
    }

    public static void RemoveObject(Vector3 position) {
        foreach (Vector3 key in blocks.Keys) {
            if(position==key) {
                MonoBehaviour.Destroy(blocks[key]);
                blocks.Remove(key);
            }
        }
    }
}
