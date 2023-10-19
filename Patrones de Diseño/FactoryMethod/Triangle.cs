using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    class Triangle: IGeometricFigure
    {
        public string getFigure()
        {
            return "{Triangulo}";
        }
    }
}
