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


    // �p�H��줣���
    // �}���ݩʭ��O �k�W...  ����(Debug)�Ҧ� �A�i�H�ݨ�p�H���
    private AudioSource sud;
    private Rigidbody2D rig;
    private Animator ani;

    private float hValue;
    #endregion

    #region �ƥ�

    private void Start()
    { // GetComponent<����>() �x����k�A�i�H���w��������
      // ���o������ 2D ���餸��
        rig = GetComponent<Rigidbody2D>();
    }

    // �@�������60��
    private void Update()
    {
        GetPlayerInputHorizontal();
        TurnDirection();
        Jump();
    }

    // �T�w��s�ƥ�
    // �@��T�w���� 50 ���A�x���ĳ�ϥΨ쪫�zAPI �n�b���ƥ󤺰���
    private void FixedUpdate()
    {
        Move(hValue);
    }
    #endregion

    #region ��k
    /// <summary>
    /// ���o���a��J�������b�V�ȡG���P�k�AA�BD�B���B�k
    /// </summary>
    private void GetPlayerInputHorizontal()
    {
        // ������ = ��J.���o�b�V(�b�V�W��)
        // �@�ΡG���o���a���U�����䪺�ȡA���k��1�A������-1�A�S����0
        hValue = Input.GetAxis("Horizontal");
        print("���a�����ȡG" + hValue);

    }

    [Header("���O"), Range(0.01f, 1)]
    public float gravity = 1;
  
    /// <summary>
    /// ����
    /// </summary>
    /// <param name="horizontal">�����Ȳ���</param>
    private void Move(float horizontal)
    {
        // �ϰ��ܼơF�b��k�������A���ϰ�ʡA�ȭ��󦸤�k���s��
        // ²�g�Gtransform +������ Transform �ܧΤ���
        // posMove = �����e�y�� + ���a��J��������
        Vector2 posMove = transform.position + new Vector3(horizontal, 0, 0);
        // ����.���ʮy��(�n���e���y��)
        rig.MovePosition(posMove);

    }

    private void TurnDirection()
    {
        print("���a���U�k" + Input.GetKeyDown(KeyCode.D));
        if (Input.GetKeyDown(KeyCode.D))
        {
            // �p�G���a���UD�A �N���׳]�� 0
            transform.eulerAngles = Vector3.zero;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            // �p�G���a���UA�A �N���׳]�� (0,180,0)
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    public float jump = 0.01f;
    private void Jump() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig.AddForce(new Vector2(0, jump));
        }
    }

    #endregion
}
