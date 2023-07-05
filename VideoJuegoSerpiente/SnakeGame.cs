using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoJuegoSerpiente
{
  public class SnakeGame
  {

    long numDado = 0;
    long posicionTablero = 0;
    Random random = new Random();
    bool seguirLanzando = true;

    public static string ObtenerMensaje()
    {
      return "hola";
    }

    public void IniciarPartida()
    {
      Console.WriteLine("HA INICIADO UNA NUEVA PARTIDA EN VIDEOJUEGO SNAKE");
      Console.WriteLine();

      do
      {
        //Genera número aleatorio para el dado del 1 al 6 y se lo asigna
        LanzarDado();

        //Mueve al jugador en el tablero
        posicionTablero += numDado;


        //Valida si el jugador aún puede continuar tirando
        if (posicionTablero <= 24)
        {
          Console.WriteLine($"Jugador avanza a cuadro {posicionTablero}");

          //valida si el jugador ha caido al pie de una escalera o en la cabeza de una serpiente.
          long incremento = ValidarAtajoEscaleras(posicionTablero);
          long decremento = ValidarDescensoSerpiente(posicionTablero);


          if (incremento != 0)
          {
            posicionTablero += incremento;
            Console.WriteLine($"Nueva posición en el tablero {posicionTablero}");
          }

          if (decremento != 0)
          {
            posicionTablero += decremento;
            Console.WriteLine($"Nueva posición en el tablero {posicionTablero}");
          }
          
          Console.Write("Presione ENTER para lanzar el dado de nuevo: ");
          Console.ReadLine();
        }
        //Validaciones personalizadas para cuando el jugador ha terminado la partida
        else if (posicionTablero == 25)
        {
          Console.WriteLine("Jugador ha llegado al cuadro 25");
          Console.WriteLine("FIN");
          seguirLanzando = false;
        }
        else if (posicionTablero > 25)
        {
          Console.WriteLine("Jugador ha superado el cuadro 25");
          Console.WriteLine("FIN");
          seguirLanzando = false;
        }

      } while (seguirLanzando);

      Console.ReadKey();
    }

    public long ValidarAtajoEscaleras(long posicionTablero)
    {
      //variable para controlar cuanto avanzara el usuario en el tablero
      long incremento = 0;

      if (posicionTablero == 3 ||
        posicionTablero == 6 || 
        posicionTablero == 9 || 
        posicionTablero == 10)
      {
        Console.WriteLine("Caiste al pie de la escalera, recibiste un incremento!");
      }

      switch (posicionTablero)
      {
        case 3:
          incremento = 8;
          break;
        case 6:
          incremento = 11;
          break;
        case 9:
          incremento = 9;
          break;
        case 10:
          incremento = 2;
          break;
        default:
          incremento = 0;
          break;
      }
      return incremento;
    }

    public long ValidarDescensoSerpiente(long posicionTablero)
    {
      //variable para controlar cuanto desciende el usuario en el tablero
      long decremento = 0;

      if (posicionTablero == 14 ||
        posicionTablero == 19 ||
        posicionTablero == 22 ||
        posicionTablero == 24)
      {
        Console.WriteLine("Caiste en la cabeza de una serpiente, vas a descender :(");
      }

      switch (posicionTablero)
      {
        case 14:
          decremento = -10;
          break;
        case 19:
          decremento = -11;
          break;
        case 22:
          decremento = -2;
          break;
        case 24:
          decremento = -8;
          break;
        default:
          decremento = 0;
          break;
      }
      return decremento;

    }

    public long LanzarDado()
    {
      numDado = random.NextInt64(1, 7);
      Console.WriteLine();
      Console.WriteLine($"Dado arroja : {numDado}");
      return numDado;
    }
  }
}
