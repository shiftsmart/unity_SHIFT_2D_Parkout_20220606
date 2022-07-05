using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerDead : MonoBehaviour
{


    [SerializeField, Header("目標名稱")]
    private string nameTarget = "牛頭人";

    [SerializeField, Header("結束管理器")]
    private ManagerFinal managerfinal;

    [SerializeField, Header("cm攝影機")]
    private GameObject goCM;

 
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name.Contains(nameTarget)) {

            managerfinal.stringTitle = "不好耶!";
            managerfinal.enabled = true;
            goCM.SetActive(false);
        }






    }


}
