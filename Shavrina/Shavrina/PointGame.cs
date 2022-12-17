using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shavrina
{
    public class PointObject
    {

        public Color colorPoint;
        public PointF pointCoordinates;
        public bool connect, give, accept = false;
        public PointObject(Color colorPoint, PointF pointCoordinates, bool connect, bool give, bool accept)

        {
            this.colorPoint = colorPoint;
            this.pointCoordinates = pointCoordinates;
            this.connect = connect;
            this.give = give;
            this.accept = accept;
        }
    }
}
