using UnityEngine;

public class InputListener : MonoBehaviour {
    public static int seed=999;

    public void OnEndEdit(string value){
        seed=int.Parse(value);
    }
}