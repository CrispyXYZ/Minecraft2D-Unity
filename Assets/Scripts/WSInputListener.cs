using UnityEngine;

public class WSInputListener : MonoBehaviour {
    public static int size=128;

    public void OnEndEdit(string value){
        size=int.Parse(value);
    }
}