namespace View.Helper
{
    /// <summary>
    /// Общие константы для типов фигур и форматирования.
    /// </summary>
    internal static class FigureConstants
    {
        public const string AllFigures = "Все";
        public const string Sphere = "Сфера";
        public const string Pyramid = "Пирамида";
        public const string Parallelepiped = "Параллелепипед";

        public const string VolumeFormat = "F6";

        public static readonly string[] FigureTypes =
        {
            Sphere,
            Pyramid,
            Parallelepiped
        };

        public static readonly string[] FigureTypesWithAll =
        {
            AllFigures,
            Sphere,
            Pyramid,
            Parallelepiped
        };
    }
}
