using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NAIADIDE
{
    public class PaintUnit:IPaintItem
    {
        private Image w_itemImage;
        private Point w_itemLocation;
        private string w_itemName = "Unnamed";
        private Font w_itemFont;
        private bool w_status= false;
        private bool w_doubleClickCheck = false;
        private bool w_selectedStatus = false;
        public bool selectStatus
        {
            get { return w_selectedStatus; }
            set { w_selectedStatus = value; }
        }
        //private bool w_doubleClickCheck = false;
        public bool doubleClickCheck
        {
            get { return w_doubleClickCheck; }
            set { w_doubleClickCheck = value; }
        }
        public bool status
        {
            get { return w_status; }
            set { w_status = value; }
        }
        public Image itemImage
        {
            get
            {
                return w_itemImage;
            }
            set{
                w_itemImage = value;
            }
        }
        private int w_number;
        public int number 
        {
            get { return w_number; }
            set { w_number = value; }
        }
        public Point itemLocation
        {
            get {
                return w_itemLocation;
            }
            set {
                w_itemLocation = value;
            }

        }
        public string itemName
        {
            get
            {
                return w_itemName;
            }
            set {
                w_itemName = value;
            }
        }
        public Font itemFont
        {
            get
            { return w_itemFont; }
            set
            { w_itemFont = value; }
        }
       
        public PaintUnit()
        { }
        public PaintUnit(string itemName, Image itemImage, Point itemLocation, Pen itemPen, Font itemFont,bool status,int number)
        {
            w_itemName = itemName;
            w_itemImage = itemImage;
            //w_itemstatus = itemstatus;
            w_itemLocation = itemLocation;
            w_itemFont = itemFont;
            w_status = status;
            w_number = number;
           // w_doubleClickCheck = doubleCheck;
        }

   
        public void DrawSelf(Graphics grp, Pen pen)
        {
            grp.DrawImage(itemImage, itemLocation);
            SizeF nameSize = grp.MeasureString(itemName, this.itemFont);
            PointF namePoint = new PointF();
            namePoint.X = itemLocation.X + (itemImage.Width - nameSize.Width) / 2;
            namePoint.Y = itemLocation.Y + itemImage.Height + 5;
            grp.DrawString(itemName, this.itemFont, new SolidBrush(Color.Black), namePoint);
            grp.DrawRectangle(pen, itemLocation.X, itemLocation.Y, itemImage.Width, itemImage.Height);
        }

    }
}
