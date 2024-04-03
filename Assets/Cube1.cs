using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube1 : MonoBehaviour
{
    public static Cube1 instance;//static 変数でCube1型のインスタンスを保持
    int num=0;//インスタンスフィールドに戻す(staticを外す)
    void Awake(){
        //初回のAwakeの時のみここがtrueになりインスタンスが登録される
        if(instance==null){
            instance=this;//このインスタンスをstatic な instanceに登録
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);//２回目以降重複して作成してしまったgameObjectを削除
        }
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            num++;
            Debug.Log(num);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            SceneManager.LoadScene("Scene2");
        }
    }
    //numのゲッターを作成しておく
    public int GetNum(){
        return this.num;
    }
}
