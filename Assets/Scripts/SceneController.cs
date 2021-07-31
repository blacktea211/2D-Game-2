using UnityEngine;

using UnityEngine.SceneManagement;  // 引用 場景管理API

public class SceneController : MonoBehaviour
{
    // Unity無法掛上腳本兩大原因
    // 1. 任何一本 腳本有 紅色蚯蚓
    // 2. 按鈕 On Click 設定點擊事件為此物件以及要呼叫的方法

    //  Unity按鈕如何與腳本溝通
    //  1.公開的方法
    //  2.需要實體物件掛此腳本

    /// <summary>
    /// 載入遊戲場景
    /// </summary>
    public void LoadGameSence()
    {
       // 等兩秒再載入遊戲場景
       // 延遲呼叫(方法名稱 延遲時間)
       // 作用：等待時間後再呼叫指定方法
        Invoke("DelayLoadGames", 2);
    
    }

    // 等待一段時間再執行方法
    // Invoke 延遲呼叫
    /// <summary>
    /// 延遲載入場景
    /// </summary>
    private void DelayLoadGame() 
    {
        // 場景管理.仔入場景("場景名稱")
        SceneManager.LoadScene("遊戲場景");    
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGaame()
    {
        Invoke("DelayQuitGames",2);
    }

    private void DelayQuitGame() 
    {
        Application.Quit();    // 應用程式，離開 - 離開遊戲
        print("離開遊戲");      // Quit 在編輯器內不會執行
    }
}
