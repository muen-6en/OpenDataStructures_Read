using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataStructures_Read.ViewModel
{
    /// <summary>
    /// Array操作
    /// </summary>
    public interface ArrayOperation
    {
        /// <summary>
        /// 取得する
        /// </summary>
        /// <param name="n">要素位置</param>
        /// <returns>取得した要素</returns>
        string Get(int n);

        /// <summary>
        /// 設定する
        /// </summary>
        /// <param name="n">要素位置</param>
        /// <param name="value">値</param>
        void Set(int n, string value);

        /// <summary>
        /// 追加する
        /// </summary>
        /// <param name="n">要素位置</param>
        /// <param name="value"></param>
        void Add(int n, string value);

        /// <summary>
        /// 削除する
        /// </summary>
        /// <param name="n">要素位置</param>
        void Remove(int n);

        /// <summary>
        /// データサイズを変更する
        /// </summary>
        void Resize();
        
    }
}
