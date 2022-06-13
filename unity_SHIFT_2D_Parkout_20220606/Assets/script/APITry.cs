using UnityEngine;

public class APITry : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {

        #region 練習

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
        print("照相機數量: " + Camera.allCameras.Length);
        print("平台: " + Application.platform);
        Physics.sleepThreshold = 10f;
        Time.timeScale = 0.5f;
        Vector3.Distance(new Vector3(1, 1, 1), new Vector3(22, 22, 22));
        Mathf.RoundToInt(9.999f);
        Application.OpenURL("https://unity.com/" );
    }

    // Update is called once per frame
    void Update()
    {

        #region 練習

        //Physics2D.gravity = new Vector2(Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f));


        //print(Random.Range(1, 5));


        #endregion
        print("經過時間: " + Time.time);


        print("有按下任何鍵嗎?: " + Input.anyKey);
        if (Input.GetKey(KeyCode.Space)) {
            print("我按空白了 " );
        }
    }
}
