 
using UnityEngine;


namespace SHIFT{ 

/// <summary>
/// �D�R�AAPI
/// �P�R�A���t�O�b��ݭn�@�ӡi���骫��j
/// ���骫�� �@�Ӧs�b������W���C������ GAMEOBJECT
/// </summary>
/// 
public class APINonStatic : MonoBehaviour
{
        ///1.�w�q���A������������O
        ///2.UNITY�ݩʭ��O�����T�w����줣�O�ŭ� NONE
        ///3.�ϥΫD�R�AAPI
        [SerializeField]
        private GameObject cow;

        [SerializeField]
        private Transform startpoint;

        private void Start()
        {
            ///�D�R�A�ݩ�
            ///1.���o
            ///�y�k:
            ///���W�١A�D�R�A�ݩ�
            print("�����Ұʪ��A"+cow.activeInHierarchy);
            print("�����w�]�ϼh:"+cow.layer);
            ///2.�]�w
            ///�y�k:
            ///���W��,�D�R�A�ݩ� ���w ��:
            ///cow.activeInHierarchy=false;(���~�A�߿W�ݩʡB�x��S�g)
            cow.tag = "Player";
            cow.layer = 4;

        }

        private void Update()
        {
            ///�D�R�A�ݩ�
            ///1.���o
            ///�y�k:
            ///���W�١A�D�R�A�ݩ�
            print("�����Ұʪ��A" + cow.activeInHierarchy);
            print("�����w�]�ϼh:" + cow.layer);
            print("�����_�I�y��:" + startpoint.position);
            ///2.�]�w
            ///�y�k:
            ///���W��,�D�R�A�ݩ� ���w ��:
            ///cow.activeInHierarchy=false;(���~�A�߿W�ݩʡB�x��S�g)
            cow.tag = "Player";
            cow.layer = 4;
            startpoint.position = new Vector3(0,5,0);
            //3.�ϥΫD�R�A��k
            //�y�k :���W�١A �D�R�A��k(�������޼�)
            cow.SetActive(false);

        }

    }


}
