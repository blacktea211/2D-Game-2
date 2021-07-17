using UnityEngine;

// 認識運算子
// 1.數學運算子
public class LearnOperator : MonoBehaviour
{

    public int a = 10;
    public int b = 3;
    public int c = 7;
    public int hp = 100;

    public float scoreA = 99;
    public float scoreB = 1;
    private float health = 100f;
    private int key = 1;
    private int chest = 1;
    private int diamond = 1;

    private void Start()
    {

        #region  數學運算子

        print(a + b);   // 13  加
        print(a - b);   // 7   減
        print(a * b);   // 30  乘
        print(a / b);   // 3   除
        print(a % b);   // 1   餘數

        // 遞增 ++
        c = c + 1;    // = 指定符號 ：右邊先運算在指定給左邊
        c++;          // 簡寫
        print("c運算後的結果：" + c);

        // 遞減 -- 

        // 指定運算 - 適用加減乘除餘  (按照程式順序計算)
        // 例：扣血 13
        hp = hp - 13;   // 100 - 13 = 87
        hp -= 13;       // 87 - 13 =74

        // 例：補血 20 
        hp += 13;       // 74 + 13 = 87

        #endregion

        #region 比較運算子

        // >    <    >=    <=    ==    !=
        // 使用比較運算子的結果 都是布林值
        // 比較正確結果為  正確維true  否則為false
        print("99大於1："+ (scoreA > scoreB));         // true
        print("99小於於1："+ (scoreA < scoreB));       // false
        print("99大於等於1："+ (scoreA >= scoreB));    // true
        print("99小於等於1："+ (scoreA <= scoreB));    // false
        print("99等於1："+ (scoreA == scoreB));       // false 
        print("99不等於1："+ (scoreA != scoreB));     // true

        #endregion

        #region  邏輯運算子
        print("邏輯運算子");
        // 比較兩筆 布林值 的資料

        print("並且");
        // 並且  &&
        // 只要有一個布林值為false  結果就為false
        print(true && true);      // true
        print(true && false);     // false
        print(false && true);     // false
        print(false && false);     // false

        print("或者");
        // 或者 ||
        // 只要有一個布林值為true  結果就為true
        print(true || true);      // true
        print(true || false);     // true
        print(false || true);     // true
        print(false || false);    // false

        // 過關條件：血量 大於 0 並且鑰匙 要等於 1 
        print("是否過關："+ (health > 0 && key == 1));
        // 過關條件：寶相 大於 5 或者鑽石 要大於 2 
        print("是否過關：" + (chest > 5 || diamond > 2));

        // 相反 !
        print(!true);    // falsse
        print(!false);   // true

        #endregion
    }
}
