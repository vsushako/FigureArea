using System;

namespace FigureArea.Figures
{
    /// <summary>
    /// Triangle class
    /// </summary>
    public class Triangle: IFigureArea
    {
        private double? _area;
        private bool? _isSquareA;
        private bool? _isSquareB;
        private bool? _isSquareC;

        private double? _a { get; set; }
        private double? _b { get; set; }
        private double? _c { get; set; }

        /// <summary>
        /// Flag indicates what Triangle is square 
        /// </summary>
        public bool? IsSquare
        {
            get
            {
                if (_isSquareA.HasValue || _isSquareB.HasValue || _isSquareC.HasValue)
                    return _isSquareA == true || _isSquareB == true || _isSquareC == true;

                if (!A.HasValue || !B.HasValue || !C.HasValue)
                    throw new ArgumentNullException($"not all sides are set");

                _isSquareA = A.Value == Math.Sqrt(Math.Pow(B.Value, 2) + Math.Pow(C.Value, 2));
                _isSquareB = B.Value == Math.Sqrt(Math.Pow(A.Value, 2) + Math.Pow(C.Value, 2));
                _isSquareC = C.Value == Math.Sqrt(Math.Pow(A.Value, 2) + Math.Pow(B.Value, 2));

                return _isSquareA == true || _isSquareB == true || _isSquareC == true;
            }
        }

        private void SideChanged()
        {
            _area = null;
            _isSquareA = null;
            _isSquareB = null;
            _isSquareC = null;
        }
        
        /// <summary>
        /// A side of the Triangle
        /// </summary>
        public double? A { get => _a; set
            {
                SideChanged();
                _a = value;
            }
        }

        /// <summary>
        /// B side of the Triangle
        /// </summary>
        public double? B { get => _b; set
            {
                SideChanged();
                _b = value;
            }
        }

        /// <summary>
        /// C side of the Triangle
        /// </summary>
        public double? C { get => _c; set
            {
                SideChanged();
                _c = value;
            }
        }
        
        /// <summary>
        /// Area of the Triangle
        /// </summary>
        public double Area {
            get
            {
                // if we already calculate area no need to recalculate it
                if (_area.HasValue) return _area.Value;
                if (!A.HasValue || !B.HasValue || !C.HasValue)
                    throw new ArgumentNullException($"not all sides are set");

                if (IsSquare == true)
                {
                    // Check witch side are square
                    if (_isSquareA == true) return .5 * C.Value * B.Value;
                    if (_isSquareB == true) return .5 * A.Value * C.Value;
                    if (_isSquareC == true) return .5 * A.Value * B.Value;
                }

                // Calculating by common formula
                var p = (A.Value + B.Value + C.Value) / 2;
                _area = Math.Sqrt(p * (p - A.Value) * (p - B.Value) * (p - C.Value));
                return _area.Value;
            }
        }
    }
}
