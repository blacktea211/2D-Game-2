using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    #region �ƥ�
    private void Update()
    {
        CheckState();
    }
    #endregion

    #region ��k
    /// <summary>
    /// �ˬd���A
    /// </summary>
    private void CheckState() 
    {
        switch (state)
        {
            case StateEnemy.idle;
                break; 
            case StateEnemy.walk;
                break;
            case StateEnemy.track;
                break;
            case StateEnemy.attack;
                break;
            case StateEnemy.dead;
                break;
          
        }
    }
    #endregion
}
