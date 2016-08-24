using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace NAIADIDE
{
    public class PaintPanel:Control
    {
       // private List<IPaintItem> w_unitNameList = new List<IPaintItem>();
        private List<IPaintItem> w_straightLine = new List<IPaintItem>();
        private List<IPaintItem> w_curveLine = new List<IPaintItem>();
        private List<IPaintItem> w_paintItems = new List<IPaintItem>();
        private IPaintItem w_ClickedItem = null;
        private Pen w_pointedBoardPen = new Pen(Color.White);
        private Point w_pointInItem;
       
        internal List<IPaintItem> PaintItems
        {
            get {return w_paintItems;}
            set {
                w_paintItems = value;
                Refresh();
            }
        }
        internal List<IPaintItem> CurveLine
        {
            get { return w_curveLine; }
            set
            {
                w_curveLine = value;
                Refresh();
            }
        }
        internal List<IPaintItem> StraightLine
        {
            get { return w_straightLine; }
            set
            {
                w_straightLine = value;
                Refresh();
            }
        }
       //PaintItems
        private bool w_drawLine = false;
        public bool DrawLine
        {
            get { return w_drawLine; }
            set { w_drawLine = value; }
        }
        private Bitmap buffermap = null;
        private Graphics buffergps = null;
        private Image DefaultImage = new Bitmap(60,60);
        
        public PaintPanel()
        {
            Graphics gps = Graphics.FromImage(DefaultImage);
            gps.DrawEllipse(new Pen(Color.Red), 0, 0, DefaultImage.Width, DefaultImage.Height);
            buffermap = new Bitmap(60, 60);
            buffergps = Graphics.FromImage(buffermap);
            //finishingImg = (Image)img.Clone();
            //orginalImg = (Image)img.Clone();    
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            if (this.Width == 0 && this.Height == 0)
            { }
            else
            {
                buffermap = new Bitmap(this.Width,this.Height);
                buffergps = Graphics.FromImage(buffermap);
                base.OnSizeChanged(e);
            }
            
        }
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            buffergps.Clear(this.BackColor);
            DrawItems();
            e.Graphics.DrawImage(buffermap,new Point(0,0));
            //base.OnPaint(e);
        }
        private void DrawItems()
        {
           // Image img = (Image)orginalImg.Clone();
            foreach (IPaintItem item in w_paintItems)
            {
                if (item.itemImage == null)
                    item.itemImage = DefaultImage;
                else if (item.itemImage != null && !item.selectStatus)
                    item.DrawSelf(buffergps, w_pointedBoardPen);
                else if (item.itemImage != null && item.selectStatus)
                {
                    item.DrawSelf(buffergps, new Pen(Color.Red));
                   // item.selectStatus = false;
                }
            }
            foreach (IPaintItem item in w_straightLine)
            {
                if (item.itemImage == null)
                    item.itemImage = DefaultImage;
                else if (item.itemImage != null)
                    item.DrawSelf(buffergps, w_pointedBoardPen);

            }
            foreach (IPaintItem item in w_curveLine)
            {
                if (item.itemImage == null)
                    item.itemImage = DefaultImage;
                else if (item.itemImage != null)
                    item.DrawSelf(buffergps, w_pointedBoardPen);

            }
        }
        internal IPaintItem GetItemAtPoint(Point point)
        { 
            foreach(IPaintItem item in w_paintItems)
            {
                if ((item.itemLocation.X < point.X && (item.itemLocation.X + item.itemImage.Width) > point.X) &&
                    (item.itemLocation.Y < point.Y && (item.itemImage.Height + item.itemLocation.Y) > point.Y))
                    return item;

             }
            return null;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                w_ClickedItem = GetItemAtPoint(e.Location); 
                if(w_ClickedItem != null)
                    w_pointInItem = new Point(e.X - w_ClickedItem.itemLocation.X, e.Y - w_ClickedItem.itemLocation.Y);
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!w_drawLine)
                {
                    if (w_ClickedItem != null)
                    {

                        w_ClickedItem.itemLocation = new Point(e.Location.X - w_pointInItem.X, e.Location.Y - w_pointInItem.Y);
                        Refresh();
                    }
                }
            }
           
           // base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                w_ClickedItem = null;
            }
            base.OnMouseUp(e);
            Refresh();
        }

        
    }
}
