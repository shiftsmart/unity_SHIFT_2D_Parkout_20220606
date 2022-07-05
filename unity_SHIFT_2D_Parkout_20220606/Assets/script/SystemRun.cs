using UnityEngine;


namespace SHIFT
{

    /// <summary>
    /// 跑步系統
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料:保存系統需要的資料

        //SerializeField 可讓變數顯示在面板上
        [SerializeField, Header("跑步速度"), Tooltip("這是角色的跑步速度"), Range(0, 100)]
        private float speeRun = 3.5f;
        [SerializeField, Header("跳躍高度"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;






        #endregion

        #region 功能:實作該系統的複雜方法


        private void run()
        {

         //   print("跑步中");
            rig.velocity = new Vector2(speeRun,rig.velocity.y);
        }

        //private void jump() {

        //    if (Input.GetKeyDown(KeyCode.Space)) {
        //        rig.velocity = new Vector2(rig.velocity.x, heightJump);

        //        ani.SetBool("jump", true);
        //    }
        
        //}
        #endregion


        #region 事件:程式入口
        private void Awake()
        {

            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();

        }
        private void Start()
        {
        //    print("安安，世界");
        }

        private void Update()
        {
           
            //  print("<color=red>yaaaaa</color>");

            run();
        }


        #endregion

        public void OnDisable()
        {
            rig.velocity = new Vector2(0,0);
        }
    }
}
