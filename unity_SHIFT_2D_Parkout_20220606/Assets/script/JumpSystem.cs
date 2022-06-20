
using UnityEngine;

namespace SHIFT
{

    /// <summary>
    /// ���D�t��
    /// </summary>
    public class JumpSystem : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickjump;


        #endregion

        #region �ƥ�
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }


        private void Update()
        {
            jumpkey();


        }

        private void FixedUpdate()
        {

            jumpforce();

        }

        #endregion

        #region �\��
        private void jumpforce()
        {

            if (clickjump)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickjump = false;
            }
        }
        private void jumpkey()
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                clickjump = true;

            }
        }

        #endregion

    }



}
