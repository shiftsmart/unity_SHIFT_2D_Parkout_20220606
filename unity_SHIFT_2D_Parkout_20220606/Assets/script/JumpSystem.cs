
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
        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layerCheckGround;
        [SerializeField, Header("���D�ʵe�Ѽ�")]
        private string nameJump = "jump";

        [SerializeField, Header("���D����")]
        private AudioClip soundJump;


        private AudioSource aud;

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickjump;

        private bool isGround;



        #endregion

        #region �ƥ�
        //ø�Ϩƥ�
        private void OnDrawGizmos()
        {
            Gizmos.color = colorCheckGround;
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);

        }

        /// <summary>
        /// �ˬd�O�_�I��a�O
        /// </summary>
        private void CheckGround()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0, layerCheckGround);
            //   print("�I�쪺����:" + hit.name);

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

        #region �\��
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
