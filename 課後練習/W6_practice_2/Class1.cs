using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace W6_practice_2
{
    class TextFont
    {
        public int Size; // 字體大小
        public FontFamily Family; // 字型
        public FontStyle Style; // 風格(粗體、斜體)
        public ContentAlignment Alignment; // 字的位置(左中右)
        public int Y_Location = 9; //字的位置(上下)
        public void ChangeLabel(ref System.Windows.Forms.Label label) {
                label.Font = new Font(Family, Size, Style);
            if(Alignment!=null)
                label.TextAlign = Alignment;
        } // 將label改變字體與位置
        public void ChangeAlignment(int type) {
            switch (type)
            {
                case 1:
                    Alignment = ContentAlignment.TopLeft;
                    break;
                case 2:
                    Alignment = ContentAlignment.TopCenter;
                    break;
                case 3:
                    Alignment = ContentAlignment.TopRight;
                    break;
                case 4:
                    Alignment = ContentAlignment.MiddleLeft;
                    break;
                case 5:
                    Alignment = ContentAlignment.MiddleCenter;
                    break;
                case 6:
                    Alignment = ContentAlignment.MiddleRight;
                    break;
                case 7:
                    Alignment = ContentAlignment.BottomLeft;
                    break;
                case 8:
                    Alignment = ContentAlignment.BottomCenter;
                    break;
                case 9:
                    Alignment = ContentAlignment.BottomRight;
                    break;

                default: break;
            }
        }// 改變 ContentAlignment

        public void ChangeFamily(string newFamily)
        {
            Family = new FontFamily(newFamily);
        }// 改變 FontFamily
        public void ChangeStyle(bool bold, bool italic) {
            if (bold && italic)
                Style = FontStyle.Bold | FontStyle.Italic;
            else if (!bold && italic)
                Style = FontStyle.Italic;
            else if (bold && !italic)
                Style = FontStyle.Bold;
            else Style = FontStyle.Regular;

        }// 改變 FontStyle






    }
}
