using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    #region 事件
    private void Update()
    {
        CheckState();
    }
    #endregion

    #region 方法
    /// <summary>
    /// 檢查狀態
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
