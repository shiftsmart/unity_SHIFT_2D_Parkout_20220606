using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SHIFT { 
public class ManagerPass : MonoBehaviour
{

    [SerializeField, Header("�ؼЦW��")]
    private string nameTarget = "���Y�H";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemrun ;
        [SerializeField, Header("���D�t��")]
        private JumpSystem jumpSystem;
        [SerializeField, Header("�����޲z��")]
        private ManagerFinal managerFinal;


        private void OnTriggerEnter2D(Collider2D collision)
    {


            if (collision.name.Contains(nameTarget)) {
                systemrun.enabled = false;
                jumpSystem.enabled = false;
               // systemrun.OnDisable();
                managerFinal.enabled = true;

                managerFinal.stringTitle = "�n�C!";

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