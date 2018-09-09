using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using point_and_line;

namespace point_and_line
{
    public class line
    {

        public point StartPoint { get; set; }
        public point EndPoint { get; set; }
        public line()
        {
            StartPoint =new point();
            EndPoint = new point();
        }
        public line(point startPoint, point endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }
        public int GetSPX()
        {
            return this.StartPoint.getX();
        }
        public void SetSPX(int x)
        {
            this.StartPoint.setX(x);
        }
        public int GetSPY()
        {
            return this.StartPoint.getY();
        }
        public void SetSPY(int y)
        {
            this.StartPoint.setY(y);
        }
        public int GetEPX()
        {
            return this.EndPoint.getX();
        }
        public void SetEPX(int x)
        {
            this.EndPoint.setX(x);
        }
        public int GetEPY()
        {
            return this.EndPoint.getY();
        }
        public void SetEPY(int y)
        {
            this.EndPoint.setY(y);
        }
        /// <summary>
        /// طول خط
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public static Double lengh(line l)
        {
            return point.distance(l.StartPoint,l.EndPoint);
        }
        /// <summary>
        /// شیب خط
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public static Double slope(line l)
        {
            return (l.EndPoint.getY() - l.StartPoint.getY()) / (l.EndPoint.getX() - l.StartPoint.getX());
        }
        public override string ToString()
        {
            return $"startpoint: x = {this.GetSPX()} y = {this.GetSPY()} /n endpoint: x = {this.GetEPX()} y = {this.GetEPY()}";
        }
    }
}
