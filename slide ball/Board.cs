using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace slide_ball
{
    public class Board : View
    {
        Vector4 red; 
        Vector4 blue;
        const int RADIUS = 60;
        public float dx
        {
            get
            {
                return blue.Z;
            }
            set
            {
                blue.Z = value;
            }
        }
        public float dy
        {
            get
            {
                return blue.W;
            }
            set
            {
                blue.W = value;
            }
        }
        public Board(Context c) : base(c)
        {
            red = new Vector4();
            blue = new Vector4();
            int width = ((Activity)c).Window.WindowManager.DefaultDisplay.Width;
            int height = ((Activity)c).Window.WindowManager.DefaultDisplay.Height;
            
            red.X = 1 * width / 4 - RADIUS / 2;
            red.Y = height / 2 - RADIUS / 2;
            red.Z = 1;
            red.W = 1;
            blue.X = 3 * width / 4 - RADIUS / 2;
            blue.Y = height / 2 - RADIUS / 2;
        }

        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
            Paint p = new Paint();
            p.Color = Color.Red;
            canvas.DrawCircle(red.X, red.Y, RADIUS, p);
            p.Color = Color.Blue;
            canvas.DrawCircle(blue.X, blue.Y, RADIUS, p);
            blue.X += blue.Z
        }
    }
}