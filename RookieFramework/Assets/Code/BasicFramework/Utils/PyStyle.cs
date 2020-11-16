// personal license onlyps

/*=============================================================================
	 PyStyle.cs
	 2020-11-15 20:57 created by zipzap <zipzap92@163.com>
	 DESC: python 风格的api
=============================================================================*/

using System;
using System.Collections.Generic;

namespace Code.BasicFramework.Utils
{
    public static class PyStyle
    {
        /// <summary>
        /// Range(4) 返回迭代器序列 0,1,2,3
        /// </summary>
        /// <param name="max">不包含最大值</param>
        /// <returns>没有reset的迭代器</returns>
        public static IEnumerable<int> Range(int max)
        {
            for (int i = 0; i < max; i++) {
                yield return i;
            }
        }

        /// <summary>
        /// Range(1,6,2) 返回迭代器序列 1,3,5
        /// </summary>
        /// <param name="min">起始</param>
        /// <param name="max">不包含最大值</param>
        /// <param name="step">步长</param>
        /// <returns>没有reset的迭代器</returns>
        public static IEnumerable<int> Range(int min, int max, int step = 1)
        {
            for (int i = min; i < max; i += step) {
                yield return i;
            }
        }

        /// <summary>
        /// 截取片段
        /// </summary>
        /// <param name="list">原始数组</param>
        /// <param name="start">起始，可以为负数代表倒数</param>
        /// <param name="end">结束，不包含，可以为负数代表倒数</param>
        /// <typeparam name="T">类型</typeparam>
        /// <returns>没有reset的迭代器</returns>
        /// <exception cref="Exception"></exception>
        public static IEnumerable<T> Slice<T>(IList<T> list, int start, int end)
        {
            var len = list.Count;
            if (start < 0) {
                start += len;
            }

            if (end < 0) {
                end += len;
            }

            if (start > end) {
                throw new Exception("start is bigger than end!");
            }

            for (int i = start; i < end; i++) {
                yield return list[i];
            }
        }
    }
}