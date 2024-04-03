using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube2 : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            SceneManager.LoadScene("Singleton");
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            //Cube1.instanceでシングルトンのCube1インスタンスにアクセス
            Debug.Log("num:"+Cube1.instance.GetNum());
        }
    }
}
