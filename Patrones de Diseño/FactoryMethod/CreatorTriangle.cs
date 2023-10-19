using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    class CreatorTriangle: GeometricFigure
    {
        public override IGeometricFigure NewFigureFactoryMethod()
        {
            return new Triangle();
        }
    }
}
