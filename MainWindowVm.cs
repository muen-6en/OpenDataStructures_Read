using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataStructures_Read
{
    /// <summary>
    /// メインウィンドウVM
    /// </summary>
    public class MainWindowVm
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindowVm()
        {


        }

        // プロパティ
        public string SelectedType = string.Empty;

        /// <summary>
        /// <summary>
        /// 選択する要素一覧
        /// </summary>
        public List<int> element = new List<int>()
        {
            // TODO: 要素と紐づける
            0, 1, 2, 3, 4
        };

        public bool ArrayChecked {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// データ構造説明
        /// </summary>
        public string arrayEx
        {
            get
            {
                // Todo: 選択しているデータ構造に合わせた説明文を表示する
                return "説明文";
            }
        }

        /// <summary>
        /// 操作説明
        /// </summary>
        public string operationEx
        {
            get
            {
                // Todo: 選択しているデータ構造に合わせた説明文を表示する
                return "操作説明";
            }
        }

        /// <summary>
        /// データ処理結果説明
        /// </summary>
        public string resultEx
        {
            get
            {
                return "データの処理結果";
            }
        }

        /// <summary>
        /// 追加要素表示可否
        /// </summary>
        public bool VisibilityAddElement { 
            get
            {
                return false;
            } 
        }
    }
}
