using UnityEngine;


namespace SHIFT
{

    /// <summary>
    /// �]�B�t��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ���:�O�s�t�λݭn�����

        //SerializeField �i���ܼ���ܦb���O�W
        [SerializeField, Header("�]�B�t��"), Tooltip("�o�O���⪺�]�B�t��"),Range(0,100)]
        private float speeRun = 3.5f; 
        [SerializeField, Header("���D����"), Range(0,3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;

        #endregion

        #region �\��:��@�Өt�Ϊ�������k



        #endregion


        #region �ƥ�:�{���J�f

        private void Start()
        {
            print("�w�w�A�@��"); 
        }

        private void Update()
        {

            print("<color=red>yaaaaa</color>");


        }


        #endregion

    }
}
