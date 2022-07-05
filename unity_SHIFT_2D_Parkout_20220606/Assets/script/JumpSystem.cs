
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
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("檢查地板顏色")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layerCheckGround;
        [SerializeField, Header("跳躍動畫參數")]
        private string nameJump = "jump";

        [SerializeField, Header("跳躍音效")]
        private AudioClip soundJump;


        private AudioSource aud;

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickjump;

        private bool isGround;



        #endregion

        #region 事件
        //繪圖事件
        private void OnDrawGizmos()
        {
            Gizmos.color = colorCheckGround;
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);

        }

        /// <summary>
        /// 檢查是否碰到地板
        /// </summary>
        private void CheckGround()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0, layerCheckGround);
            //   print("碰到的物件:" + hit.name);

            isGround = hit;
            //   print(isGround);
        }


        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            aud = GetComponent<AudioSource>();
        }


        private void Update()
        {
            UpdateAnimator();
            jumpkey();
            CheckGround();

        }

        private void FixedUpdate()
        {

            jumpforce();

        }

        #endregion

        #region 功能
        private void jumpforce()
        {

            if (clickjump && isGround)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickjump = false;

              aud.PlayOneShot(soundJump,Random.Range(0.7f,1.5f));
            }
        }
        private void jumpkey()
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                clickjump = true;

            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickjump = false;

            }
        }


        private void UpdateAnimator()
        {
            ani.SetBool(nameJump, !isGround);

        }

        #endregion

    }



}
