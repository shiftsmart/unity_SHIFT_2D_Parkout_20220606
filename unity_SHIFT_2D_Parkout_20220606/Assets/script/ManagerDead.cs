using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerDead : MonoBehaviour
{


    [SerializeField, Header("�ؼЦW��")]
    private string nameTarget = "���Y�H";

    [SerializeField, Header("�����޲z��")]
    private ManagerFinal managerfinal;

    [SerializeField, Header("cm��v��")]
    private GameObject goCM;

 
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name.Contains(nameTarget)) {

            managerfinal.stringTitle = "���n�C!";
            managerfinal.enabled = true;
            goCM.SetActive(false);
        }






    }


}
