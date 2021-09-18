using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldCreator : MonoBehaviour
{
    public void OnClick(){
        SceneManager.LoadScene("GameScene");
    }
}
