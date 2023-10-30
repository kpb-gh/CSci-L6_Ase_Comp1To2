﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSci_L6_Ase_Comp1To2
{
    class ObjectDrawer
    {
        ///<summary>Class for drawing objects. Provides the code that actually creates the object and places it with appropriate offset</summary>
        ///
        public static ObjectShape DrawObject(int xPos, int yPos, int xSiz, int ySiz, int eCnt, Brush b, bool fill)
        {
            ///<summary>Base method for creating ObjectShapes. Used to create more useful shapes.</summary>
            int[] coords = new int[4] { xPos + 751, yPos + 19, xSiz, ySiz };
            
            return new ObjectShape(coords, b, fill);
        }

        public static void DrawCircle(ObjectShape oShape, PaintEventArgs e)
        {
            ///<summary>Draw an elipsis at [xPos,yPos] with size [xSiz,ySiz]. CommandParser will ensure xSiz==ySiz in case of circle not oval.</summary>
            ///
            if (oShape.f)
            {
                e.Graphics.FillEllipse(oShape.b, new Rectangle(oShape.coords[0], oShape.coords[1], oShape.coords[2], oShape.coords[3]));
            } else
            {
                e.Graphics.DrawEllipse(new Pen(oShape.b, 1), new Rectangle(oShape.coords[0], oShape.coords[1], oShape.coords[2], oShape.coords[3]));
            }
        }
        public static void DrawRectangle(ObjectShape oShape, PaintEventArgs e)
        {
            ///<summary>Draw a rectangle of size and location ObjectShape.pb.Bounds. Fill determined by args.</summary>
            ///
            if (oShape.f)
            {
                e.Graphics.FillRectangle(oShape.b, new Rectangle(oShape.coords[0], oShape.coords[1], oShape.coords[2], oShape.coords[3]));
            } else
            {
                e.Graphics.DrawRectangle(new Pen(oShape.b, 1), new Rectangle(oShape.coords[0], oShape.coords[1], oShape.coords[2], oShape.coords[3]));
            }
        }

        public static void DrawLine(ObjectShape oShape, PaintEventArgs e)
        {
            ///<summary>Draw a line connecting the corners of the passed ObjectShape.</summary>
            ///
            Pen pen = new Pen(oShape.b);
            Point p1 = new Point(oShape.coords[0], oShape.coords[1]);
            Point p2 = new Point(oShape.coords[2], oShape.coords[3]);
            e.Graphics.DrawLine(pen,p1,p2);
        }
    }
}