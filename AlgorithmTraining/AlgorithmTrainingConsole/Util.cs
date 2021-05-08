using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTrainingConsole
{
    public class Util
    {
        /// <summary>
        /// 双重数组生成不重复的随机数
        /// </summary>
        /// <param name="length"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int[] UseDoubleArrayToNonRepeatedRandom(int length, int minValue, int maxValue)
        {
            int seed = Guid.NewGuid().GetHashCode();
            Random radom = new Random(seed);
            int[] index = new int[length];
            for (int i = 0; i < length; i++)
            {
                index[i] = i + 1;
            }

            int[] array = new int[length]; // 用来保存随机生成的不重复的数 
            int site = length;             // 设置上限 
            int idx;                       // 获取index数组中索引为idx位置的数据，赋给结果数组array的j索引位置
            for (int j = 0; j < length; j++)
            {
                idx = radom.Next(0, site - 1);  // 生成随机索引数
                array[j] = index[idx];          // 在随机索引位置取出一个数，保存到结果数组 
                index[idx] = index[site - 1];   // 作废当前索引位置数据，并用数组的最后一个数据代替之
                site--;                         // 索引位置的上限减一（弃置最后一个数据）
            }
            return array;
        }
    }
}
