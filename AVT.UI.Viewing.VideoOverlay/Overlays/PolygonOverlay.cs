using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace AVT.Viewing.UI.VideoOverlay.Overlays
{
  public class PolygonOverlay : OverlayDrawing
  {
    public PolygonOverlay() : base()
    {

    }

    public List<Point> Points { get; set; } = new List<Point>();

    public Color BorderColor { get; set; } = Colors.Red;

    public Color FillColor { get; set; } = Colors.Transparent;
  }
}
