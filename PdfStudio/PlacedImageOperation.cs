using System.Windows;

namespace PdfStudio;

public sealed class PlacedImageOperation
{
    public required int PageIndex { get; set; }
    public required string SourcePath { get; init; }
    public required Rect PdfRect { get; set; }
    public int RotationDegrees { get; set; }
    public double Opacity { get; set; } = 1;
    public bool LockAspectRatio { get; set; } = true;
}