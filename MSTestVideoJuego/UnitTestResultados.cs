using VideoJuegoSerpiente;

namespace MSTestVideoJuego
{
  [TestClass]
  public class UnitTestResultados
  {
    [TestMethod]
    public void TestMethodDado7()
    {
      var snakeGame = new SnakeGame();
      var resultDado = snakeGame.LanzarDado();
      Assert.AreNotEqual(7,resultDado);
    }

    [TestMethod]
    public void TestMethodDadoNulo()
    {
      var snakeGame = new SnakeGame();
      var resultDado = snakeGame.LanzarDado();
      Assert.IsNotNull(resultDado);
    }

    [TestMethod]
    public void TestMethodDescensoSerpiente1()
    {
      var snakeGame = new SnakeGame();
      
      var resultDescenso = snakeGame.ValidarDescensoSerpiente(14);
      Assert.AreEqual(-10,resultDescenso);
      
    }

    [TestMethod]
    public void TestMethodDescensoSerpiente2()
    {
      var snakeGame = new SnakeGame();

      var resultDescenso = snakeGame.ValidarDescensoSerpiente(19);
      Assert.AreEqual(-11, resultDescenso);

    }

    [TestMethod]
    public void TestMethodDescensoSerpiente3()
    {
      var snakeGame = new SnakeGame();

      var resultDescenso = snakeGame.ValidarDescensoSerpiente(22);
      Assert.AreEqual(-2, resultDescenso);

    }

    [TestMethod]
    public void TestMethodDescensoSerpiente4()
    {
      var snakeGame = new SnakeGame();

      var resultDescenso = snakeGame.ValidarDescensoSerpiente(24);
      Assert.AreEqual(-8, resultDescenso);

    }

    [TestMethod]
    public void TestMethodDescensoSerpiente5()
    {
      var snakeGame = new SnakeGame();

      var resultDescenso = snakeGame.ValidarDescensoSerpiente(100);
      Assert.AreEqual(0, resultDescenso);

    }

    [TestMethod]
    public void TestMethodAtajoEscaleras1()
    {
      var snakeGame = new SnakeGame();

      var resultAtajo = snakeGame.ValidarAtajoEscaleras(3);
      Assert.AreEqual(8, resultAtajo);
    }

    [TestMethod]
    public void TestMethodAtajoEscaleras2()
    {
      var snakeGame = new SnakeGame();

      var resultAtajo = snakeGame.ValidarAtajoEscaleras(6);
      Assert.AreEqual(11, resultAtajo);
    }

    [TestMethod]
    public void TestMethodAtajoEscaleras3()
    {
      var snakeGame = new SnakeGame();

      var resultAtajo = snakeGame.ValidarAtajoEscaleras(9);
      Assert.AreEqual(9, resultAtajo);
    }

    [TestMethod]
    public void TestMethodAtajoEscaleras4()
    {
      var snakeGame = new SnakeGame();

      var resultAtajo = snakeGame.ValidarAtajoEscaleras(10);
      Assert.AreEqual(2, resultAtajo);
    }

    [TestMethod]
    public void TestMethodAtajoEscaleras5()
    {
      var snakeGame = new SnakeGame();

      var resultAtajo = snakeGame.ValidarAtajoEscaleras(100);
      Assert.AreEqual(0, resultAtajo);
    }


  }
}