
using UnityEngine;

public class Player : MonoBehaviour
{
    #region �m��

    [Header("���ʳt��"), Range(0, 1000)]
    public float Movespeed = 10.5f;
    

    [Header("���D����")]
    public float Jumpheight = 100f;
    [Range(0, 3000)]

    public float hp = 100;
    [Range(0, 200)]

    [Header("�O�_�b�a�O�W")]
    [Tooltip("����O�_�b�a�O�W,�O=true,�_=false")]
    public bool OnGround;

    private AudioSource sud;
    private Rigidbody2D rig;
    private Animator ani;

    #endregion

    #region �ƥ�

    #endregion


}
