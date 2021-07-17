
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

    private AudioSource sud;
    private Rigidbody2D rig;
    private Animator ani;

    #endregion

    #region 事件

    #endregion


}
