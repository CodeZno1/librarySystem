using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Category
    {
        public string[] category1 = new string[] { "玄幻", "都市", "仙侠" };
        public string[,] category2 = new string[,] { { "东方玄幻", "异世大陆", "高武世界" }, { "都市生活", "恩怨情仇", "青春校园" }, { "修真文明", "现代修真", "古典仙侠" } };
        public string[,,] category3 = new string[,,] { { { "圣墟", "太初", "牧神", "武炼", "银霸" }, { "天尊", "监武","造化", "诸天", "万古"}, { "霸皇", "纯阳", "藏经", "星河", "神门" } },{ { "真聊", "纯真","今朝",
                    "重生","美食" }, { "市武", "侠警", "黑金", "纵横", "杀戮" },{ "似水", "重返", "沸腾", "心动", "天才" } }, { { "极道", "天魔", "大劫", "夏纪", "飞仙" },{ "数据", "无限", "悠闲", "仙尊", "夺运" },
                { "问道", "聊斋", "蜀山", "证道", "太玄" } } };

        public Category()
        {

        }
    }
}
