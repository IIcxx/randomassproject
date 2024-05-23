using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Raylib_cs;
public class Item{
   public int Cost;
   public string Name;
}

public class stackable : Item{
   public int Amount;


}
public class weapon : Item{
   public bool Owned = false;
  public int Damage;
  public int Crit;
   private Random dmgGenerator;
   private Random critGenerator;
  public void attack(){
   
  dmgGenerator = new Random();
   Damage = dmgGenerator.Next(5, 10);
   critGenerator = new Random();
   Crit = critGenerator.Next(0,3);
   if(Crit == 0){
   Raylib.DrawText("Attack failed",0,0,24,Color.BLACK);
  }
  else if(Crit >= 1){
   Raylib.DrawText($"Attack Succeded and did {Crit * Damage} damage",0,0,24,Color.BLACK);
  }
}
}

