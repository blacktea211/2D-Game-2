using UnityEngine;

public class Player : MonoBehaviour
{
    #region 練習

    [Header("移動速度"), Range(0, 1000)]
    public float Movespeed = 10.5f;
    

    [Header("跳躍高度")]
    public float Jumpheight = 100f;
    [Range(0, 3000)]

    public float hp = 100;
    [Range(0, 200)]

    [Header("是否在地板上")]
    [Tooltip("角色是否在地板上,是=true,否=false")]
    public bool OnGround;


    // 私人欄位不顯示
    // 開啟屬性面板 右上...  除錯(Debug)模式 ，可以看到私人欄位
    private AudioSource sud;
    private Rigidbody2D rig;
    private Animator ani;

    private Flare hValue;
    #endregion

    #region 事件

    private void Start()
    { // GetComponent<類型>() 泛型方法，可以指定任何類型
      // 取得此物件的 2D 剛體元件
        rig = GetComponent<Rigidbody2D>();
    }

    // 一秒約執行60次
    private void Update()
    {
        GetPlayerInputHorizontal();
    }

    // 固定更新事件
    // 一秒固定執行 50 次，官方建議使用到物理API 要在此事件內執行
    private void FixedUpdate()
    {
        
    }
    #endregion


    #region 方法

    private void GetPlayerInputHorizontal() 
    {
        // 水平值 = 輸入.取得軸向(軸向名稱)
        // 作用：取得玩家按下水平鍵的值，按右為1，按左為-1，沒按為0
        hValue = Input.GetAxis("Horizontal");
        print("玩家水平值：" + hValue);

    }

    private void Move(float horizontal)
    {
        // 區域變數；在方法內的欄位，有區域性，僅限於次方法內存取
        // 簡寫：transform +此物件的 Transform 變形元件
        // posMove = 角色當前座標 + 玩家輸入的水平值
        Vector2 posMove = transform.position + new Vector3(horizontal, 0, 0);
        // 鋼體.移動座標(要往前的座標)
        rig.MovePosition(posMove);

    }

    private void Jump() 
    {
    
    }

    #endregion
}
