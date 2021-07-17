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

}