using System;

namespace FigureArea.Figures
{
    /// <summary>
    /// Circle class
    /// </summary>
    public class Circle: IFigureArea
    {
        private double? _radius;
        private double? _area;

        /// <summary>
        /// radius of the circle
        /// </summary>
        public double? Radius
        {
            get => _radius;
            set {
                // we set area to null for recalculating it when it needed
                _area = null;
                _radius = value;
            }
        }

        /// <summary>
        /// Area of the circle
        /// </summary>
        public double Area
        {
            get
            {
                // if we already calculate area no need to recalculate it
                if (_area.HasValue) return _area.Value;

                if (!Radius.HasValue)
                    throw new ArgumentNullException($"radius value not set");

                _area = Math.PI * Radius.Value * Radius.Value;
                return _area.Value;

            }
        }
    }
}
