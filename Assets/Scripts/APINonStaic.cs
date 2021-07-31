
using UnityEngine;

public class APINonStaic : MonoBehaviour
{
    // API ��� ����j��
    // 1.  �R�A Static �G ������r Static
    // 2.  �D�R�A NonStatic�G�L����r Static

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
        #region �{�ѫD�R�A�ݩ�
        /*
        // 1. ���oP �R�A�ݩ�
        // print("���o�y�СG" + Transform.position); // ���~�G�ݭn������Ѧ�

        // 2.�ϥ� �D�R�A �ݩ�
        // �� �y�k�G���.�D�R�A�ݩ�
        print("���o�ߤ���y�СG" + traA.position);
        print("���o��v���I���C��G" + cam.backgroundColor);

        // 3. �]�w�D�R�A�ݩ�
        // �� �y�k�G�D�R�A�ݩ� ���w �� ;
        cam.backgroundColor = new Color(0.7f, 0.3f, 0.5f);

        //4. �I�s�D�R�A�ݩ�
        // �� �y�k�G ���.�D�R�A��k(�����޼�) ;
        traB.Translate(1, 0, 0);
        lightA.Reset(); 
        
         */
        #endregion

        #region �m��
                         
        print("��v���`�סG" + cam1.depth);
        print("�Ϥ����C��G" + spr1.color);

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
