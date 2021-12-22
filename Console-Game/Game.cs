using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    //Actualizamos la posicion del cursor segun la tecla que se haya pulsado
    public new static void UpdatePosition(string keyPress, out int x, out int y){
      y=0;
      x=0;
      if(keyPress == "DownArrow"){
        y++;
        x=0;
      }
      else if (keyPress == "UpArrow"){
        y--;
        x=0;
      }
      else if (keyPress == "LeftArrow"){
        x--;
        y=0;
      }
      else if(keyPress == "RightArrow"){
        x++;
        y=0;
      }
      else{
        y=0;
        x=0;
      }
    }

    //Actualiza el caracter con el que se dibuja el cursor
    public new static char UpdateCursor(string keyPress){
      if(keyPress == "DownArrow")
        return 'v';
      else if (keyPress == "UpArrow")
        return '^';
      else if (keyPress == "LeftArrow")
        return '<';
      else if(keyPress == "RightArrow")
        return '>';
      else
        return '>';
      }

    //Impedimos que el cursor vaya mas alla de los limites
    public new static int KeepInBounds(int coord, int max){
        if(coord < 0)
          return 0;
        else if(coord >= max)
          return max-1;
        else
          return coord;
      }

    //Comprobamos si la fruta y el cursor estan en la misma posicion
    public new static bool DidScore(int xChar, int yChar, int xFruit, int yFruit){
        if(xChar == xFruit && yChar == yFruit)
          return true;
        else
          return false;

      }

    
  }
}