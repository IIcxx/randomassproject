using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;


public class ChurchBuilding
{
  public Rectangle rect;
  public ChurchBuilding(int x, int y)
  {
    rect = new Rectangle(x, y, 125, 75);
  }

  public void Draw()
  {
    Raylib.DrawRectangle((int)rect.x, (int)rect.y, (int)rect.width, (int)rect.height, Color.BEIGE);
  }
}




