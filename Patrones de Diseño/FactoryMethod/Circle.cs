using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    internal class Circle: IGeometricFigure
    {
        public string getFigure()
        {
            return "{Circulo}";
        }
    }
}
