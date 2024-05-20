using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;
using System.Windows;


Raylib.InitWindow(1024, 800, "Zamnin");
Raylib.SetTargetFPS(60);

String scene = "Start";   //variables
bool alive = true;
int Level = 1;
int Currency = 0;
int Lvl = 1;


Rectangle Character = new Rectangle(50, 50, 45, 45); //Character
Rectangle tp = new Rectangle(400, 700, 100, 100);
Rectangle Store = new Rectangle(300, 300, 100, 100);

//HouseBuilding House = new HouseBuilding(300,300);
ChurchBuilding Church = new ChurchBuilding(600, 600);


while (Raylib.WindowShouldClose() == false)
{
  //UI logic

  if (scene == "Start" && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
  { // makes sure you can start the game from the start screen
    scene = "Game";
  }
  if (scene == "Game" && alive == false)
  { // takes you to the end screen and does the hard reset when you die.
    scene = "End";
    reset();
  }
  if (scene == "End" && Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
  {
    scene = "Start";
  }

  if (scene == "Win" && Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
  {
    scene = "Start";
    reset();
  }
  if (Raylib.IsKeyPressed(KeyboardKey.KEY_L))
  { //for testing purposes

  }
  //other logic

  void reset()
  { //a hard reset 
  }

  if (scene == "Game" && Raylib.IsKeyDown(KeyboardKey.KEY_W) && Level >= 1)
  {  //movement for the character

    Character.y -= 5;
  }
  if (scene == "Game" && Raylib.IsKeyDown(KeyboardKey.KEY_S) && Level >= 1)
  {

    Character.y += 5;
  }
  if (scene == "Game" && Raylib.IsKeyDown(KeyboardKey.KEY_D) && Level >= 1)
  {

    Character.x += 5;
  }
  if (scene == "Game" && Raylib.IsKeyDown(KeyboardKey.KEY_A) && Level >= 1)
  {

    Character.x -= 5;
  }

  Character.x = Math.Max(0, Math.Min(974, Character.x));  //makes sure you can't go out of bounds
  Character.y = Math.Max(0, Math.Min(750, Character.y));


  //graphics

  if (scene == "Game")
  {
    Raylib.ClearBackground(Color.GREEN);


    // Create a list to hold rectangles
    List<Rectangle> rect1List = new List<Rectangle>();

    // Add rectangles and their X  + Y for 'Level 1' values to the list
    rect1List.Add(CreateRectangle(60, 230));
    rect1List.Add(CreateRectangle(250, 500));
    rect1List.Add(CreateRectangle(150, 300));
    rect1List.Add(CreateRectangle(800, 500));
    rect1List.Add(CreateRectangle(450, 60));
    rect1List.Add(CreateRectangle(600, 700));
    rect1List.Add(CreateRectangle(890, 90));
    rect1List.Add(CreateRectangle(600, 400));
    //rectangleList.Add(CreateRectangle(0, 0)); test rect

    List<Rectangle> rect2List = new List<Rectangle>();

    // Adds the hitboxes for the level 1 rectangles and their values to the list
    rect2List.Add(CreateRectangle2(55, 225));
    rect2List.Add(CreateRectangle2(245, 495));
    rect2List.Add(CreateRectangle2(145, 295));
    rect2List.Add(CreateRectangle2(795, 495));
    rect2List.Add(CreateRectangle2(445, 55));
    rect2List.Add(CreateRectangle2(595, 695));
    rect2List.Add(CreateRectangle2(885, 85));
    rect2List.Add(CreateRectangle2(595, 395));
    //rectangleList.Add(CreateRectangle(0, 0)); test rect
    List<Rectangle> rect3List = new List<Rectangle>();

    // Add rectangles and their X  + Y for 'Level 1' values to the list
    rect3List.Add(CreateRectangle(700, 600));
    rect3List.Add(CreateRectangle(250, 500));
    rect3List.Add(CreateRectangle(150, 700));
    rect3List.Add(CreateRectangle(600, 500));
    rect3List.Add(CreateRectangle(450, 60));
    rect3List.Add(CreateRectangle(600, 200));
    rect3List.Add(CreateRectangle(90, 90));
    rect3List.Add(CreateRectangle(900, 125));
    //rectangleList.Add(CreateRectangle(0, 0)); test rect

    List<Rectangle> rect4List = new List<Rectangle>();

    // Adds the hitboxes for the level 1 rectangles and their values to the list
    rect4List.Add(CreateRectangle2(695, 595));
    rect4List.Add(CreateRectangle2(245, 495));
    rect4List.Add(CreateRectangle2(145, 695));
    rect4List.Add(CreateRectangle2(595, 495));
    rect4List.Add(CreateRectangle2(445, 55));
    rect4List.Add(CreateRectangle2(595, 195));
    rect4List.Add(CreateRectangle2(85, 85));
    rect4List.Add(CreateRectangle2(895, 120));
    //rectangleList.Add(CreateRectangle(0, 0)); test rect
    List<Rectangle> rect5List = new List<Rectangle>();

    // Add rectangles and their X  + Y for 'Level 1' values to the list
    rect5List.Add(CreateRectangle(60, 230));
    rect5List.Add(CreateRectangle(250, 500));
    rect5List.Add(CreateRectangle(150, 300));
    rect5List.Add(CreateRectangle(800, 500));
    rect5List.Add(CreateRectangle(450, 60));
    rect5List.Add(CreateRectangle(600, 700));
    rect5List.Add(CreateRectangle(890, 90));
    rect5List.Add(CreateRectangle(600, 400));
    //rectangleList.Add(CreateRectangle(0, 0)); test rect

    List<Rectangle> rect6List = new List<Rectangle>();

    // Adds the hitboxes for the level 1 rectangles and their values to the list
    rect6List.Add(CreateRectangle2(55, 225));
    rect6List.Add(CreateRectangle2(245, 495));
    rect6List.Add(CreateRectangle2(145, 295));
    rect6List.Add(CreateRectangle2(795, 495));
    rect6List.Add(CreateRectangle2(445, 55));
    rect6List.Add(CreateRectangle2(595, 695));
    rect6List.Add(CreateRectangle2(885, 85));
    rect6List.Add(CreateRectangle2(595, 395));
    //rectangleList.Add(CreateRectangle(0, 0)); test rect

    //adds the width and height to the rectangles and their hitboxes in the levels. Uneven = graphic, even = hitbox
    //level 1
    static Rectangle CreateRectangle(int x, int y)
    {
      int houseWH = 75;

      return new Rectangle(x, y, houseWH, houseWH);
    }
    static Rectangle CreateRectangle2(int x, int y)
    {
      int houseWH2 = 85;

      return new Rectangle(x, y, houseWH2, houseWH2);
    }
    Raylib.DrawRectangle((int)Store.x, (int)Store.y, (int)Store.width, (int)Store.height, Color.YELLOW);
    Raylib.DrawRectangle((int)tp.x, (int)tp.y, (int)tp.width, (int)tp.height, Color.MAGENTA);

    if (Raylib.CheckCollisionRecs(Character, Church.rect))
    {
      System.Console.WriteLine("hej");
    }

    if (Raylib.CheckCollisionRecs(Store, Character) == true && Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
    {
      scene = "Store";
    }
    if (Level == 1)
    {

      Church.Draw();
      foreach (Rectangle rect in rect1List)
      {
        Raylib.DrawRectangle((int)rect.x, (int)rect.y, (int)rect.width, (int)rect.height, Color.RED);
        if (Raylib.CheckCollisionRecs(rect, Character) == true && Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
          Character.y += 5;
        }
        if (Raylib.CheckCollisionRecs(rect, Character) == true && Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
          Character.y -= 5;
        }
        if (Raylib.CheckCollisionRecs(rect, Character) == true && Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
          Character.x -= 5;
        }
        if (Raylib.CheckCollisionRecs(rect, Character) == true && Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
          Character.x += 5;
        }
      }
    }
    else if (Level == 2)
    {
      // ChurchBuilding Church = new ChurchBuilding(400, 230);
      Church.Draw();

      foreach (Rectangle rect3 in rect3List)
      {
        Raylib.DrawRectangle((int)rect3.x, (int)rect3.y, (int)rect3.width, (int)rect3.height, Color.RED);
        if (Raylib.CheckCollisionRecs(rect3, Character) == true && Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
          Character.y += 5;
        }
        if (Raylib.CheckCollisionRecs(rect3, Character) == true && Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
          Character.y -= 5;
        }
        if (Raylib.CheckCollisionRecs(rect3, Character) == true && Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
          Character.x -= 5;
        }
        if (Raylib.CheckCollisionRecs(rect3, Character) == true && Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
          Character.x += 5;
        }
      }

    }
    else if (Level == 3)
    {
      // ChurchBuilding Church = new ChurchBuilding(100, 150);
      Church.Draw();
      foreach (Rectangle rect5 in rect5List)
      {
        Raylib.DrawRectangle((int)rect5.x, (int)rect5.y, (int)rect5.width, (int)rect5.height, Color.RED);
        if (Raylib.CheckCollisionRecs(rect5, Character) == true && Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
          Character.y += 5;
        }
        if (Raylib.CheckCollisionRecs(rect5, Character) == true && Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
          Character.y -= 5;
        }
        if (Raylib.CheckCollisionRecs(rect5, Character) == true && Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
          Character.x -= 5;
        }
        if (Raylib.CheckCollisionRecs(rect5, Character) == true && Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
          Character.x += 5;
        }
      }

    }

    Raylib.DrawRectangle((int)Character.x, (int)Character.y, (int)Character.width, (int)Character.height, Color.BLACK);
    if (Raylib.CheckCollisionRecs(tp, Character) == true)
    {
      Level = 0;
      Raylib.DrawRectangle(0, 0, 1024, 800, Color.GREEN);
      Raylib.DrawRectangle(100, 100, 824, 600, Color.WHITE);
      Raylib.DrawRectangle(200, 175, 624, 125, Color.LIGHTGRAY);
      Raylib.DrawRectangle(200, 325, 624, 125, Color.LIGHTGRAY);
      Raylib.DrawRectangle(200, 475, 624, 125, Color.LIGHTGRAY);
      Raylib.DrawText("Press 1 to go to Level 1", 225, 200, 32, Color.BLACK);
      Raylib.DrawText("Press 2 to go to Level 2", 225, 350, 32, Color.BLACK);
      Raylib.DrawText("Press 3 to go to Level 3", 225, 500, 32, Color.BLACK);
      if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE) == true)
      {
        Character.x = 50;
        Character.y = 50;
        tp.x = 400;
        tp.y = 700;
        Store.x = 300;
        Store.y = 300;
        Level = 1;
      }
      if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO) == true)
      {
        tp.x = 200;
        tp.y = 0;
        Store.x = 0;
        Store.y = 0;
        Level = 2;
      }
      if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE) == true)
      {
        tp.x = 700;
        tp.y = 400;
        Store.x = 0;
        Store.y = 0;
        Level = 3;
      }
    }
    if (Level > 0)
    {
      Lvl = Level;
    }

    Raylib.DrawText($"You have: {Currency} Coins", 670, 50, 24, Color.BLACK);
    Raylib.DrawText($"You are currently on Level {Lvl}", 670, 20, 24, Color.BLACK);
  }
  else if (scene == "Store")
  {
    if (Raylib.IsKeyPressed(KeyboardKey.KEY_BACKSPACE) == true)
    {
      scene = "Game";
    }
    Raylib.ClearBackground(Color.SKYBLUE);
    Raylib.DrawRectangle(100, 100, 824, 600, Color.WHITE);
    Raylib.DrawRectangle(175, 175, 325, 125, Color.LIGHTGRAY);
    Raylib.DrawRectangle(175, 325, 325, 125, Color.LIGHTGRAY);
    Raylib.DrawRectangle(175, 475, 325, 125, Color.LIGHTGRAY);
    Raylib.DrawRectangle(525, 175, 325, 125, Color.LIGHTGRAY);
    Raylib.DrawRectangle(525, 325, 325, 125, Color.LIGHTGRAY);
    Raylib.DrawRectangle(525, 475, 325, 125, Color.LIGHTGRAY);
    Raylib.DrawText("Press BACKSPACE to exit store", 600, 115, 18, Color.BLACK);
    Raylib.DrawText("Press 1 to buy # \n for # Coins", 200, 200, 24, Color.BLACK);
    Raylib.DrawText("Press 2 to buy # \n for # Coins", 200, 350, 24, Color.BLACK);
    Raylib.DrawText("Press 3 to buy # \n for # Coins", 200, 500, 24, Color.BLACK);
    Raylib.DrawText("Press 4 to buy # \n for # Coins", 550, 200, 24, Color.BLACK);
    Raylib.DrawText("Press 5 to buy # \n for # Coins", 550, 350, 24, Color.BLACK);
    Raylib.DrawText("Press 6 to buy # \n for # Coins", 550, 500, 24, Color.BLACK);
    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ONE) == true)
    {

    }
    if (Raylib.IsKeyPressed(KeyboardKey.KEY_TWO) == true)
    {
    }

    if (Raylib.IsKeyPressed(KeyboardKey.KEY_THREE) == true)
    {

    }
    if (Raylib.IsKeyPressed(KeyboardKey.KEY_FOUR) == true)
    {

    }
    if (Raylib.IsKeyPressed(KeyboardKey.KEY_FIVE) == true)
    {

    }
    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SIX) == true)
    {

    }
  }
  else if (scene == "Start")
  {
    Raylib.ClearBackground(Color.SKYBLUE);
    Raylib.DrawRectangle(100, 100, 824, 600, Color.WHITE);
    Raylib.DrawText("Epic title", 375, 150, 50, Color.BLUE);
    Raylib.DrawText("Press ENTER to Start game", 275, 250, 32, Color.BLUE);

  }

  else if (scene == "End")
  {

  }
  else if (scene == "Win")
  {


  }

  Raylib.EndDrawing();
}


