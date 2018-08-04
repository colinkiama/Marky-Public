using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace Marky.Core
{
    public static class Win2DStuff
    {
        public static Size MeasureTextSize(string text, CanvasTextFormat textFormat, float limitedToWidth = 0.0f, float limitedToHeight = 0.0f)
        {
            var device = CanvasDevice.GetSharedDevice();

            var layout = new CanvasTextLayout(device, text, textFormat, limitedToWidth, limitedToHeight);

            var width = layout.DrawBounds.Width;
            var height = layout.DrawBounds.Height;

            return new Size(width, height);
        }
    }
}
