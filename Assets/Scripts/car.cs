using UnityEngine;  // 引用Unity引擎 提供的API  (UnityEngine 命名空間)
// 類別
// 語法：關鍵字 腳本名稱
public class car : MonoBehaviour
{
    #region 註解

    // 註解

    // 欄位：儲存簡單的資料
    // 語法：
    // 資料類型  欄位名稱  指定符號  預設值  結尾
    // 指定符號 =

    // 修飾詞：
    // 1.預設  private 私人 - 不顯示
    // 2.      public  公開 - 顯示

    /*
     * 
     * 多行註解
     * 多行註解
     * 多行註解
     * 
     */

    #endregion

    #region Unity常用四大類型 float int string bool

    // Unity 常用四大類型
    // float   浮點數 ： 1.1254
    // int     整數   ： 1 , 2 , 3
    // string  字串   ： 文字 , 對話內容 ,  
    // bool    布林值 ： true , false

    #endregion

    #region  定義欄位 - 屬性  語法  標題  提示  範圍

    // 定義欄位  以車為例
    // Unity " 以屬性 Inspector 面板上的值為主 "
    public float weight = 3.73f;
    private int cc = 2000;
    public string brand = "賓士";
    public bool windowsky = true;

    // 可使用中文 " 不建議 "  - 編輯與效能轉換的問題
    // 獨立開發 團隊許可
    public int 輪胎數量 = 4;

    // 欄位屬性：輔助欄位添加額外功能
    // 欄位語法：[屬性名稱(屬性值)]
    // 標題： [Header("字串")]

    [Header("輪胎數量")]
    public int Tires = 4;

    // 提示：[Tooltip("字串")]
    [Tooltip("這欄位作用是紀錄汽車高度")]
    public float height = 1.5f;

    // 範圍：[Range(最小數值 , 最大數值)] - " 僅限數值類型 float 和 int "
    [Range(1, 20)]

    #endregion

    #region  其他類型 - 顏色  按鍵  遊戲物件與元件
    // 顏色 Color
    public Color color1;                                      // 不指定為黑色透明
    public Color red = Color.red;                             // 使用預設顏色
    public Color blue = Color.blue;
    public Color colorCustom1 = new Color(150, 200, 80.6F);          // 自訂顏色( R, G, B )
    public Color colorCustom2 = new Color(1, 5, 10, 50f);     // 自訂顏色( R, G, B, A )

    // 座標 2維 - 4維
    // 保存數值資訊 . 浮點數
    // 加 - 號  => 反方向
    public Vector2 v2;
    public Vector2 vZero = Vector2.zero;
    public Vector2 vOne = Vector2.one;
    public Vector2 up = Vector2.up;
    public Vector2 down = -Vector2.up;
    public Vector2 right = Vector2.right;
    public Vector2 left = -Vector2.right;
    public Vector2 v2Custom1 = new Vector2(-100.5f, 105.3f);  //自訂座標

    public Vector3 v3;
    public Vector4 v4;

    //按鍵類型
    public KeyCode kc;
    public KeyCode forward = KeyCode.D;      // foreard 向前
    public KeyCode jump = KeyCode.Space;
    public KeyCode attack = KeyCode.Mouse0;  // 滑鼠左鍵0 , 右鍵1 ，滾輪2

    // 遊戲物件與元件
    public GameObject goCamera;  // 遊戲物件包含場景上的及專內的預置物
    public Transform traCaar;    // 位置 變形
    public SpriteRenderer sprPicture;  //圖片
    #endregion

    //  開始事件
    private void Start()
    {
        //  呼叫方法語法：方法名稱();
        Drive50();
        Drive100();
        Drive(150,("咻咻咻~"));
        Drive(180, ("上阿!阿斯拉!!"));          // 呼叫小括號內的稱為引述
        // Drive(200, "碎石");                 // 時速200，音效 上阿!阿斯拉!! ，特效-碎石  錯誤!
        Drive(200, effect："碎石");            // 使用多個預設值參數時可以使用 參數名稱：值

        float kg = KG();                      //  區域變數，僅在此括號內使用
        print("轉換為公斤數：" + kg);

        float bmi = BMI(1,10);
        print("BMI指數：" + bmi);

    }

    //  更新事件：大約一秒60次，60FPS，處理物件移動或監聽玩家輸入
    private void Update()
    {
        print("在print內顯示~");
    }

    #region  方法 ( 功能、函示 )   Method
    //  方法：實作比較複雜的行為，例如：汽車往前開，開起汽車音響並撥放音樂..
    //  欄位語法：修飾詞  類型  名稱  指定  預設值
    //  方法語法：修飾詞  傳回類型  名稱 (...)  {程式區塊}
    //  類型：void-無回傳
    //  定義方法 ， 不會執行的 " 必須呼叫 " ，呼叫的方式：在事件 ( Start ) 內呼叫此方法
    //  維護性，擴充性
    
    private void Drive50()
    {
        print("開車中~時速50");
    }  
    private void Drive100()
    {
        print("開車中~時速100");
    }

    //  參數語法：類型 參數名稱 - 寫在小括號內，僅在此方法內 ( 大括號內 ) 可使用
    //  參數1，參數2，參數3...參數N
    //  參數預設值： 類型  參數名稱 指定 值(選填式參數)
    //  ★預設值只能放在最右邊


    /// <summary>
    /// 開車的方法，用來控制車子的速度 , 音效， 特效
    /// </summary>
    /// <param name="speed">車子的移動速度</param>
    /// <param name="sound">車子的聲音</param>
    /// <param name="effect">車子的特效</param>
    private void Drive(int speed,string sound = "咻咻咻",string effect = "灰塵") 
    {
        print("開車中~時速" + speed);
        print("開車音效：" + sound);
        print("開車特效：" + effect);
    }

    /// <summary>
    /// 噸位轉換為公斤
    /// </summary>
    /// <returns>轉換為公斤的重量資訊</returns>
    private float KG()
    {
        return weight * 100;    
    }

    /// <summary>
    /// 計算BMI
    /// </summary>
    /// <param name="weight">體重(公斤)</param>
    /// <param name="hight">身高(公尺)</param>
    /// <returns></returns>
    private float BMI(float weight,float hight)
    {
        return weight / (height * height);
    }
    #endregion

}