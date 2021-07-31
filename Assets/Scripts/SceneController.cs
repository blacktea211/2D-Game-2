using UnityEngine;

using UnityEngine.SceneManagement;  // �ޥ� �����޲zAPI

public class SceneController : MonoBehaviour
{
    // Unity�L�k���W�}����j��]
    // 1. ����@�� �}���� ����L�C
    // 2. ���s On Click �]�w�I���ƥ󬰦�����H�έn�I�s����k

    //  Unity���s�p��P�}�����q
    //  1.���}����k
    //  2.�ݭn���骫�󱾦��}��

    /// <summary>
    /// ���J�C������
    /// </summary>
    public void LoadGameSence()
    {
       // �����A���J�C������
       // ����I�s(��k�W�� ����ɶ�)
       // �@�ΡG���ݮɶ���A�I�s���w��k
        Invoke("DelayLoadGames", 2);
    
    }

    // ���ݤ@�q�ɶ��A�����k
    // Invoke ����I�s
    /// <summary>
    /// ������J����
    /// </summary>
    private void DelayLoadGame() 
    {
        // �����޲z.�J�J����("�����W��")
        SceneManager.LoadScene("�C������");    
    }

    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGaame()
    {
        Invoke("DelayQuitGames",2);
    }

    private void DelayQuitGame() 
    {
        Application.Quit();    // ���ε{���A���} - ���}�C��
        print("���}�C��");      // Quit �b�s�边�����|����
    }
}
