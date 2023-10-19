using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    class CreatorSquare: GeometricFigure
    {
        public override IGeometricFigure NewFigureFactoryMethod()
        {
            return new Square();
        }
    }
}
