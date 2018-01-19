using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunshine五十音
{
    public class Property
    {
        private bool proSurd;//清音拨音
        private bool proDullness;//浊音半浊音
        private bool proOverSound;//拗音
        private bool proHiragana;//平假名
        private bool proKatakana;//片假名
        private String proData;//数据库表名

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

        public String ProData
        {
            get
            {
                return proData;
            }
            set
            {
                proData = value;
            }
        }
    }
}
