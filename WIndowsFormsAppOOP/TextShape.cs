using System;
using System.Collections.Generic;
using System.Text;

namespace WIndowsFormsAppOOP
{
    internal class TextShape
    {

        //-- Properties --//
        public double width {get;set;}
        public double height {get;set;}
        public string letters {get;set;}
        public string result {get;set; }

        //-- Constructor --//
        public TextShape()
        {
            this.width = 0;
            this.height = 0;
            this.letters = "A";
        }
        public TextShape(double width, double height)
        {
            this.width = width;
            this.height = height;
            this.letters = "A";
        }
        //-- Methods --//
        public void DrawTriangle()
        { 
            string result = "";
            for (int i = 1; i <= this.height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += this.letters;
                }
                result += Environment.NewLine;
            }
            this.result = result;

        }
        public void DrawRectangle()
        {
            string result = "";
            for (int i = 1; i <= this.height; i++)
            {
                for (int j = 1; j <= this.width; j++)
                {
                    result += this.letters;
                }
                result += Environment.NewLine;
            }
            this.result = result;
        }
    }
}
