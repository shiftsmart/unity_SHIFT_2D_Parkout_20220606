
using UnityEngine;

namespace SHIFT
{

    /// <summary>
    /// 跳躍系統
    /// </summary>
    public class JumpSystem : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickjump;


        #endregion

        #region 事件
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

        #region 功能
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
