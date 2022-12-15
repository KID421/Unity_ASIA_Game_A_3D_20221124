using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習迴圈，重複執行程式
    /// for、while、do while、foreach
    /// </summary>
    public class LearnLoop : MonoBehaviour
    {
        private void Awake()
        {
            // for 迴圈語法
            // for (初始值；布林值 條件；迴圈結束執行) { 程式 }
            for (int i = 0; i < 10; i++)
            {
                print("for 迴圈：" + i);
            }

            for (int number = 0; number < 5; number++)
            {
                print("迴圈：" + number);
            }

            if (true)
            {
                print("當 () 內的布林值為 true 執行");
            }

            int count = 0;

            while (count < 5)
            {
                print("當 () 內的布林值為 true 持續執行");
                print("while 迴圈次數：" + count);
                count++;
            }
        }
    }
}
