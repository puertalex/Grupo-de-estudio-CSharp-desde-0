using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    class Square: IGeometricFigure
    {
        public string getFigure()
        {
            return "{Cuadrado}";
        }
    }
}
