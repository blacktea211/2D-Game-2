using UnityEngine;  // �ޥ�Unity���� ���Ѫ�API  (UnityEngine �R�W�Ŷ�)
// ���O
// �y�k�G����r �}���W��
public class car : MonoBehaviour
{ 
    #region ����

    // ����

    // ���G�x�s²�檺���
    // �y�k�G
    // �������  ���W��  ���w�Ÿ�  �w�]��  ����
    // ���w�Ÿ� =

    // �׹����G
    // 1.�w�]  private �p�H - �����
    // 2.      public  ���} - ���

    /*
     * 
     * �h�����
     * �h�����
     * �h�����
     * 
     */

    #endregion

    #region Unity�`�Υ|�j���� float int string bool

    // Unity �`�Υ|�j����
    // float   �B�I�� �G 1.1254
    // int     ���   �G 1 , 2 , 3
    // string  �r��   �G ��r , ��ܤ��e ,  
    // bool    ���L�� �G true , false

    #endregion

    #region  �w�q��� - �ݩ�  �y�k  ���D  ����  �d��

    // �w�q���  �H������
    // Unity " �H�ݩ� Inspector ���O�W���Ȭ��D "
    public float weight = 3.73f;
    private int cc = 2000;
    public string brand = "���h";
    public bool windowsky = true;

    // �i�ϥΤ��� " ����ĳ "  - �s��P�į��ഫ�����D
    // �W�߶}�o �ζ��\�i
    public int ���L�ƶq = 4;

    // ����ݩʡG���U���K�[�B�~�\��
    // ���y�k�G[�ݩʦW��(�ݩʭ�)]
    // ���D�G [Header("�r��")]

    [Header("���L�ƶq")]
    public int Tires = 4;

    // ���ܡG[Tooltip("�r��")]
    [Tooltip("�o���@�άO�����T������")]
    public float height = 1.5f;

    // �d��G[Range(�̤p�ƭ� , �̤j�ƭ�)] - " �ȭ��ƭ����� float �M int "
    [Range(1, 20)]

    #endregion

    #region  ��L���� - �C��  ����  �C������P����
    // �C�� Color
    public Color color1;                                      // �����w���¦�z��
    public Color red = Color.red;                             // �ϥιw�]�C��
    public Color blue = Color.blue;
    public Color colorCustom1 = new Color(150, 200, 80.6F);          // �ۭq�C��( R, G, B )
    public Color colorCustom2 = new Color(1, 5, 10, 50f);     // �ۭq�C��( R, G, B, A )

    // �y�� 2�� - 4��
    // �O�s�ƭȸ�T . �B�I��
    // �[ - ��  => �Ϥ�V
    public Vector2 v2;
    public Vector2 vZero = Vector2.zero;
    public Vector2 vOne = Vector2.one;
    public Vector2 up = Vector2.up;
    public Vector2 down = -Vector2.up;
    public Vector2 right = Vector2.right;
    public Vector2 left = -Vector2.right;
    public Vector2 v2Custom1 = new Vector2(-100.5f, 105.3f);  //�ۭq�y��

    public Vector3 v3;
    public Vector4 v4;

    //��������
    public KeyCode kc;
    public KeyCode forward = KeyCode.D;      // foreard �V�e
    public KeyCode jump = KeyCode.Space;
    public KeyCode attack = KeyCode.Mouse0;  // �ƹ�����0 , �k��1 �A�u��2

    // �C������P����
    public GameObject goCamera;  // �C������]�t�����W���αM�����w�m��
    public Transform traCaar;    // ��m �ܧ�
    public SpriteRenderer sprPicture;  //�Ϥ�
    #endregion

}