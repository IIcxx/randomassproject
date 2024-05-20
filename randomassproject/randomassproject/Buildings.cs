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
public class StoreB
{
  public Rectangle Store;
  public StoreB(int x, int y)
  {
    Store = new Rectangle(x, y, 100, 100);
  }

  public void Draw()
  {
    Raylib.DrawRectangle((int)Store.x, (int)Store.y, (int)Store.width, (int)Store.height, Color.WHITE);
  }
}



