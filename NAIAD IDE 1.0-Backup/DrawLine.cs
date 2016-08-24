using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using NAIADIDE;
using System.Drawing.Drawing2D;

namespace NAIADIDE
{
    public class DrawLine:NAIADIDE.IPaintItem
    {
        private string w_itemName;
        private bool w_status = false;
        private bool w_selectedStatus = false;
        public bool selectStatus
        {
            get { return w_selectedStatus; }
            set { w_selectedStatus = value; }
        }
        private bool w_doubleClickCheck = false;
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
        private int w_number;
        public int number
        {
            get { return w_number; }
            set { w_number = value; }
        }
        public string itemName
        {
            get { return w_itemName; }
            set { w_itemName = value; }
        }
        private Image w_itemImage = null;

        public Image itemImage
        {
            get { return w_itemImage; }
            set { w_itemImage = value; }
        }
        
        private Point w_itemLocation;

        public Point itemLocation
        {
            get { return w_itemLocation; }
            set { w_itemLocation = value; }
        }

        private Font w_itemFont;

        public Font itemFont
        {
            get { return w_itemFont; }
            set { w_itemFont = value; }
        }

        private PaintUnit w_startPoint;

        internal PaintUnit StartPoint
        {
            get { return w_startPoint; }
            set { w_startPoint = value; }
        }

        private PaintUnit w_endPoint;

        internal PaintUnit EndPoint
        {
            get { return w_endPoint; }
            set { w_endPoint = value; }
        }

        public DrawLine()
        {
        }


        public DrawLine(string itemname, Point itemlocate, Pen itemPen, Font itemFont,int digital)
        {
            w_itemName = itemname;
            w_itemLocation = itemlocate;
            w_itemFont = itemFont;
            w_number = digital;
        }

        public void DrawSelf(Graphics grp,Pen pen)
        {
            pen = new Pen(Color.Black, 4);
            pen.StartCap = LineCap.NoAnchor;
            pen.EndCap = LineCap.ArrowAnchor;

            if (w_startPoint != null && w_endPoint != null)
            {
                //grp.DrawLine(pen, w_startPoint.itemLocation, w_endPoint.itemLocation);
                grp.DrawLine(pen, w_startPoint.itemLocation.X+itemImage.Width, w_startPoint.itemLocation.Y + itemImage.Height / 2, w_endPoint.itemLocation.X, w_endPoint.itemLocation.Y + itemImage.Height / 2);
            }

        }
    }
}
