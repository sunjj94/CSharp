using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunshine五十音
{
    public class Property
    {
        private bool proSurd;//清音拨音
        private bool proDullness;//浊音半浊音
        private bool proOverSound;//拗音
        private bool proHiragana;//平假名
        private bool proKatakana;//片假名
        private bool proReview;
        private String[] proTable = new string[3];//数据库表名
        private String proType = null;//判断练习类型 平假名、片假名、混合

        public bool ProSrud
        {
            get
            {
                return proSurd;
            }
            set
            {
                proSurd = value;
            }
        }

        public bool ProDullness
        {
            get
            {
                return proDullness;
            }
            set
            {
                proDullness = value;
            }
        }

        public bool ProOverSound
        {
            get
            {
                return proOverSound;
            }
            set
            {
                proOverSound = value;
            }
        }

        public bool ProHiragana
        {
            get
            {
                return proHiragana;
            }
            set
            {
                proHiragana = value;
            }
        }

        public bool ProKatakana
        {
            get
            {
                return proKatakana;
            }
            set
            {
                proKatakana = value;
            }
        }

        public bool ProReview
        {
            get
            {
                return proReview;
            }
            set
            {
                proReview = value;
            }
        }

        public String[] ProTable
        {
            get
            {
                return proTable;
            }
            set
            {
                proTable = value;
            }
        }

        public String ProType
        {
            get
            {
                return proType;
            }
            set
            {
                proType = value;
            }
        }

        //获取属性
        public void SetProperty(CheckBox con)
        {
            if (con.CheckState == CheckState.Checked)
            {
                switch(con.Text)
                {
                    case "清音":
                        ProSrud = true;
                        break;
                    case "浊音":
                        ProDullness = true;
                        break;
                    case "拗音":
                        ProOverSound = true;
                        break;
                    case "平假名":
                        ProHiragana = true;
                        break;
                    case "片假名":
                        ProKatakana = true;
                        break;
                    case "复习巩固":
                        ProReview = true;
                        break;
                }
            }
            else
            {
                switch (con.Text)
                {
                    case "清音":
                        ProSrud = false;
                        break;
                    case "浊音":
                        ProDullness = false;
                        break;
                    case "拗音":
                        ProOverSound = false;
                        break;
                    case "平假名":
                        ProHiragana = false;
                        break;
                    case "片假名":
                        ProKatakana = false;
                        break;
                    case "复习巩固":
                        ProReview = false;
                        break;
                }
            }
        }
    }
}
