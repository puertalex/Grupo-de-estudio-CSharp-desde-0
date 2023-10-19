namespace FactoryMethod
{
    class TerminalCreator
    {
        public void Main()
        {
            Console.WriteLine("App: Ejecución de creacion de Circulo.");
            CreateFigure(new CreatorCircle());

            Console.WriteLine("App: Ejecución de creacion de Cuadrado.");
            CreateFigure(new CreatorSquare());

            Console.WriteLine("App: Ejecución de creacion de Triangulo.");
            CreateFigure(new CreatorTriangle());
        }

        public void CreateFigure(GeometricFigure geometricFigure)
        {
            Console.WriteLine("Creador: Ejecutando la orden de crear...\n" + geometricFigure.SeeFigure());
        }
    }
}
