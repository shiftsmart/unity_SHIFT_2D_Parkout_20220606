using UnityEngine;

public class APITry : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {

        #region �m��

        //print(Random.value);


        //print(Random.insideUnitCircle);
        //print(Random.onUnitSphere);
        //print(Random.rotation);
        //print(Random.rotationUniform);
        //print(Random.state);
        //var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        //Instantiate(prefab, position, Quaternion.identity);

        //Cursor.visible = false;

        //print(Mathf.Infinity);
        //Time.timeScale = 0.2f;

        //Random.Range(20.5f, 100.5f);


        #endregion
        print("�Ӭ۾��ƶq: " + Camera.allCameras.Length);
        print("���x: " + Application.platform);
        Physics.sleepThreshold = 10f;
        Time.timeScale = 0.5f;
        Vector3.Distance(new Vector3(1, 1, 1), new Vector3(22, 22, 22));
        Mathf.RoundToInt(9.999f);
        Application.OpenURL("https://unity.com/" );
    }

    // Update is called once per frame
    void Update()
    {

        #region �m��

        //Physics2D.gravity = new Vector2(Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f));


        //print(Random.Range(1, 5));


        #endregion
        print("�g�L�ɶ�: " + Time.time);


        print("�����U�������?: " + Input.anyKey);
        if (Input.GetKey(KeyCode.Space)) {
            print("�ګ��ťդF " );
        }
    }
}
