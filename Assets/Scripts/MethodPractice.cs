using UnityEngine;
public class MethodPractice : MonoBehaviour
{
    public Camera cam;
    public SpriteRenderer spr;

    private void Start()
    {
        print("��v���`�סG" + cam.depth);
        print("�Ϥ����C��G" + spr.color);

      //  cam.backgroundColor = new Color()


    }

  
}
