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
        // This method allows you to measure the size of text. This means enables calculations that allow you to add line numbers to your
        // app. Even with text wrapping!
        // Important Note: Margins effect the width and height of the measurements.
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
