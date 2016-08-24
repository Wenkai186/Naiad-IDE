using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NAIADIDE
{
    interface IPaintItem
    {
        System.Drawing.Image itemImage { get; set; }
        System.Drawing.Point itemLocation { get; set; }
        string itemName { get; set; }
        //ItemStatus ItemStatus { get; set; }
        #region public  enum ItemStatus
        /*
                 public  enum ItemStatus 
            {
                Finished = 1 ,
                Actived =2 ,
                Watting = 4,
                Pointed = 8 

            }
         */
        #endregion


        Font itemFont { get; set; }
        bool status { get; set; }
        bool selectStatus { get; set; }
        int number { get; set; }
        bool doubleClickCheck { get; set; }

        void DrawSelf(Graphics grp, Pen pen);//Graphics is a class and cannot extends,Pen is another class which is used to draw line
    }
}
