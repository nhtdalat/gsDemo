﻿using System.Windows;
using System.Windows.Media;

namespace AVT.Viewing.UI.VideoOverlay.Overlays
{
    public class LineOverlay : OverlayDrawing
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LineOverlay() : base()
        {
        }

        /// <summary>
        /// Gets and sets the line's start cooridiante point.  Points are represented as
        /// normalized points within the range 0-1.
        /// </summary>
        public Point StartPoint { get; set; }

        /// <summary>
        /// Gets and sets the line's end cooridinate point. Points are represented as
        /// normalized points withing the range 0-1.
        /// </summary>
        public Point EndPoint { get; set; }

        /// <summary>
        /// Gets and set the color used to draw the line
        /// </summary>
        public Color LineColor { get; set; } = Colors.Blue;
    }
}
