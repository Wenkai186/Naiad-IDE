using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace NAIADIDE
{
    public class CallBackLine : NAIADIDE.IPaintItem
    {
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
        private bool w_status = false;
        public bool status
        {
            get { return w_status; }
            set { w_status = value; }
        }
        private string w_itemName;

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
        private Point w_middlePoint;
        public Point MiddlePoint
        {
            get { return w_middlePoint; }
            set { w_middlePoint = value; }
        }
        private int w_number;
        public int number
        {
            get { return w_number; }
            set { w_number = value; }
        }
       // private Point[] w_arrPoints
        public Point[] ArrPoints = null;//{ w_startPoint.itemLocation ,w_endPoint.itemLocation};
        //{ 
        //    get 
        //    {
        //        return w_arrPoints;
        //    }
        //        set{w_arrPoints = value;}
        //}
        public CallBackLine()
        {
        }

        public CallBackLine(string itemname, Point itemlocate, Pen itemPen, Font itemFont)
        {
            w_itemName = itemname;
            w_itemLocation = itemlocate;
            w_itemFont = itemFont;
        }
        public void DrawSelf(Graphics grp, Pen pen)
        {
            pen = new Pen(Color.Black, 4);
            pen.StartCap = LineCap.NoAnchor;
            pen.EndCap = LineCap.ArrowAnchor;
            Point firstOne = new Point(w_startPoint.itemLocation.X + itemImage.Width/2, w_startPoint.itemLocation.Y + itemImage.Height);
            Point middleOne = new Point((w_startPoint.itemLocation.X + w_endPoint.itemLocation.X) / 2, (w_startPoint.itemLocation.Y + w_endPoint.itemLocation.Y) / 2 + 100);
            Point lastOne = new Point(w_endPoint.itemLocation.X +itemImage.Width/ 2, w_endPoint.itemLocation.Y + itemImage.Height);
            ArrPoints = new Point[]{firstOne,middleOne,lastOne};
            if (w_startPoint != null && w_endPoint != null)
            {
                //grp.DrawLine(pen, w_startPoint.itemLocation, w_endPoint.itemLocation);
                //grp.DrawCurve(pen, w_startPoint.itemLocation.X + itemImage.Width, w_startPoint.itemLocation.Y + itemImage.Height / 2, w_endPoint.itemLocation.X, w_endPoint.itemLocation.Y + itemImage.Height / 2);
                grp.DrawCurve(pen, ArrPoints);
            }

        }
    }
}
