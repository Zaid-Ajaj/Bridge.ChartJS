namespace Bridge.ChartJS
{
    [Enum(Emit.StringName)]
    public enum PointSyles
    {
        Circle,
        Triangle,
        Rect,
        [Name("rectRot")]
        RectRot,
        Cross,
        [Name("crossRot")]
        CrossRot,
        Star,
        Line,
        Dash
    }
}