using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    class CreatorCircle: GeometricFigure
    {
        public override IGeometricFigure NewFigureFactoryMethod()
        {
            return new Circle();
        }
    }
}
