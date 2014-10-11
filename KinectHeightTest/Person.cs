using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;

namespace KinectHeightTest
{
    public class Person
    {
        public ulong PersonID { get; set; }
        public double Height { get; set; }

         public double GetHeight(Joint foot, Joint head, Body body)
        {
             foot = body.Joints[JointType.FootLeft];
            double footX = foot.Position.X;
            double footY = foot.Position.Y;

             head = body.Joints[JointType.Head];
            double headX = head.Position.X;
            double headY = head.Position.Y;

            double x2x1 = Math.Pow(headX - footX, 2);
            double y2y1 = Math.Pow(headY - footY, 2);
            double res = Math.Sqrt(x2x1 + y2y1);
            double feet = res * 3.2808;
            return feet; 
        }
    }

   
}
