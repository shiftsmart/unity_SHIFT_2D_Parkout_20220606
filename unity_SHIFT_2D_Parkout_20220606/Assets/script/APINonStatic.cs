 
using UnityEngine;


namespace SHIFT{ 

/// <summary>
/// 非靜態API
/// 與靜態的差別在於需要一個【實體物件】
/// 實體物件 一個存在於場景上的遊戲物件 GAMEOBJECT
/// </summary>
/// 
public class APINonStatic : MonoBehaviour
{
        ///1.定義欄位，資料類型為類別
        ///2.UNITY屬性面板必須確定該欄位不是空值 NONE
        ///3.使用非靜態API
        [SerializeField]
        private GameObject cow;

        [SerializeField]
        private Transform startpoint;

        private void Start()
        {
            ///非靜態屬性
            ///1.取得
            ///語法:
            ///欄位名稱，非靜態屬性
            print("牛的啟動狀態"+cow.activeInHierarchy);
            print("牛的預設圖層:"+cow.layer);
            ///2.設定
            ///語法:
            ///欄位名稱,非靜態屬性 指定 值:
            ///cow.activeInHierarchy=false;(錯誤，唯獨屬性、官方沒寫)
            cow.tag = "Player";
            cow.layer = 4;

        }

        private void Update()
        {
            ///非靜態屬性
            ///1.取得
            ///語法:
            ///欄位名稱，非靜態屬性
            print("牛的啟動狀態" + cow.activeInHierarchy);
            print("牛的預設圖層:" + cow.layer);
            print("牛的起點座標:" + startpoint.position);
            ///2.設定
            ///語法:
            ///欄位名稱,非靜態屬性 指定 值:
            ///cow.activeInHierarchy=false;(錯誤，唯獨屬性、官方沒寫)
            cow.tag = "Player";
            cow.layer = 4;
            startpoint.position = new Vector3(0,5,0);
            //3.使用非靜態方法
            //語法 :欄位名稱， 非靜態方法(對應的引數)
            cow.SetActive(false);

        }

    }


}
