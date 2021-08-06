using UnityEngine;
public class MethodPractice : MonoBehaviour
{
    public Camera cam;
    public SpriteRenderer spr;

    private void Start()
    {
        print("攝影機深度：" + cam.depth);
        print("圖片的顏色：" + spr.color);

      //  cam.backgroundColor = new Color()


    }

  
}
