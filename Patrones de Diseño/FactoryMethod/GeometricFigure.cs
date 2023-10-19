using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    abstract class GeometricFigure
    {
        public abstract IGeometricFigure NewFigureFactoryMethod();

        public string SeeFigure()
        {
            var figure = NewFigureFactoryMethod();

            var result = "Haz creado con exito la siguiente figura geometrica: " + figure.getFigure();

            return result;
        }
    }
}
