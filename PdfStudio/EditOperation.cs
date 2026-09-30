using System.Windows;
using System.Windows.Media;

namespace PdfStudio;

public enum EditKind { Edit, Add, Delete }
public enum ToolMode { Edit, Add, Delete, Move }

public sealed class EditOperation
{
    public required int PageIndex { get; set; }
    public required EditKind Kind { get; init; }
    public required Rect PdfRect { get; set; }
    public string Text { get; set; } = "";
    public string FontFamily { get; set; } = "Arial";
    public double FontSize { get; set; } = 12;
    public bool Bold { get; set; }
    public bool Italic { get; set; }
    public bool Underline { get; set; }
    public Color Color { get; set; } = Colors.Black;
    public TextAlignment Alignment { get; set; } = TextAlignment.Left;
    public double LineSpacing { get; set; } = 1.15;
    public bool IsInvisible { get; set; }
    public bool IsOcrLayer { get; set; }
}