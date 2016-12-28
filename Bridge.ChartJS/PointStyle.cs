namespace Bridge.ChartJS
{
    [Enum(Emit.StringName)]
    [External]
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