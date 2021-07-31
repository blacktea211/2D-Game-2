
using UnityEngine;

public class APINonStaic : MonoBehaviour
{
    // API 文件 分兩大種
    // 1.  靜態 Static ： 有關鍵字 Static
    // 2.  非靜態 NonStatic：無關鍵字 Static

    public Transform traA;
    public Transform traB;
    public Transform traC;
    public Camera cam;
    public Camera cam1;
    
    public Light lightA;
    public SpriteRenderer spr1;
    public Rigidbody2D rig;

    private void Start()
    {
        #region 認識非靜態屬性
        /*
        // 1. 取得P 靜態屬性
        // print("取得座標：" + Transform.position); // 錯誤：需要有物件參考

        // 2.使用 非靜態 屬性
        // ★ 語法：欄位.非靜態屬性
        print("取得立方體座標：" + traA.position);
        print("取得攝影機背景顏色：" + cam.backgroundColor);

        // 3. 設定非靜態屬性
        // ★ 語法：非靜態屬性 指定 值 ;
        cam.backgroundColor = new Color(0.7f, 0.3f, 0.5f);

        //4. 呼叫非靜態屬性
        // ★ 語法： 欄位.非靜態方法(對應引數) ;
        traB.Translate(1, 0, 0);
        lightA.Reset(); 
        
         */
        #endregion

        #region 練習
                         
        print("攝影機深度：" + cam1.depth);
        print("圖片的顏色：" + spr1.color);

        cam1.backgroundColor = Random.ColorHSV();
        spr1.flipY = true;

        #endregion


        }

    private void Update()
    {
        traC.Rotate(0, 0, 1);
        rig.AddForce(new Vector2(5, 20));
    }

}
