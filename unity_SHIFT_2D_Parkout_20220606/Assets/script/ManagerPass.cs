using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SHIFT { 
public class ManagerPass : MonoBehaviour
{

    [SerializeField, Header("目標名稱")]
    private string nameTarget = "牛頭人";
        [SerializeField, Header("跑步系統")]
        private SystemRun systemrun ;
        [SerializeField, Header("跳躍系統")]
        private JumpSystem jumpSystem;
        [SerializeField, Header("結束管理器")]
        private ManagerFinal managerFinal;


        private void OnTriggerEnter2D(Collider2D collision)
    {


            if (collision.name.Contains(nameTarget)) {
                systemrun.enabled = false;
                jumpSystem.enabled = false;
               // systemrun.OnDisable();
                managerFinal.enabled = true;

                managerFinal.stringTitle = "好耶!";

            }
        //print(collision.name);
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

}
}