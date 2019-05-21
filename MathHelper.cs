using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    /// <summary>
    /// 数学运算帮助类
    /// </summary>
    public class MathHelper
    {
        private const string CACULATE_TYPE_PLUS = "+";
        private const string CACULATE_TYPE_SUB = "-";
        private const int RADOM_PLUS_START = 4;
        private const int RADOM_PLUS_END = 9;

        private const int RADOM_SUB_START = 2;
        private const int RADOM_SUB_END = 20;

        private Random random1 = new Random();

        /// <summary>
        /// 生成一道完整的算术题
        /// </summary>
        /// <param name="cal1">第一个计算子</param>
        /// <param name="cal2">第二个计算子</param>
        /// <param name="calType">运算符</param>
        /// <param name="result">结果</param>
        public void GenerateCaculation(out int cal1, out int cal2, out string calType, out int result)
        {
            calType = string.Empty;
            result = 0;

            //随机数是偶数时，做加法
            if (Guid.NewGuid().GetHashCode() % 2 == 0)
            {
                cal1 = random1.Next(RADOM_PLUS_START, RADOM_PLUS_END);
                cal2 = random1.Next(RADOM_PLUS_START, RADOM_PLUS_END);

                result = cal1 + cal2;
                calType = CACULATE_TYPE_PLUS;
            }
            else
            {
                cal1 = random1.Next(RADOM_SUB_START, RADOM_SUB_END);
                cal2 = random1.Next(RADOM_SUB_START, RADOM_SUB_END);

                if (cal1 < cal2)
                {
                    int tmp = cal1;
                    cal1 = cal2;
                    cal2 = tmp;
                }

                result = cal1 - cal2;
                calType = CACULATE_TYPE_SUB;
            }
        }

        /// <summary>
        /// 判定是否需要继续输入
        /// </summary>
        /// <param name="result">正确结果</param>
        /// <param name="inputNum">已经输入的结果</param>
        /// <returns>True：还需要继续输入 False：不需要再输入了</returns>
        public bool IsNeedInputNextNum(int result, int inputNum)
        {
            string strResult = result.ToString();
            string strInputNum = inputNum.ToString();

            if (strResult.Length > strInputNum.Length
                && strResult.IndexOf(strInputNum) == 0)
            {
                //如果输入的值是正确结果的开头一部分，那么还需要继续输入
                return true;
            }

            return false;
        }
    }

    /// <summary>
    /// 运算符类型
    /// </summary>
    public enum CaculateType
    {
        /// <summary>
        /// 空占位
        /// </summary>
        Null,

        /// <summary>
        /// 加法
        /// </summary>
        Plus,

        /// <summary>
        /// 减法
        /// </summary>
        Subtraction,

        /// <summary>
        /// 乘法
        /// </summary>
        Multiple,

        /// <summary>
        /// 除法
        /// </summary>
        Division
    }
}
