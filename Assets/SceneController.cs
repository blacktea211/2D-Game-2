using UnityEngine;
using UnityEngine.SceneManagement;  // �ޥ� �����޲zAPI

public class SceneController : MonoBehaviour
{
    //  Unity���s�p��P�}�����q
    //  1.���}����k
    //  2.�ݭn���骫�󱾦��}��

    /// <summary>
    /// ���J�C������
    /// </summary>
    public void LoadGameSence()
    {
        SceneManager.LoadScene("�C������");
    }

    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGaame()
    {
        Application.Quit();    // ���ε{���A���} - ���}�C��
        print("���}�C��");      // Quit �b�s�边�����|����
    }
}
