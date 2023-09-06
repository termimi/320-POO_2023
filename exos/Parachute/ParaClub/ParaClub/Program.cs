using ParaClub;
Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);
Plane plane = new Plane(0,0);
plane.show();
while (true)
{
    // Modifier le modèle (ce qui *est*)
    Console.Clear();
    plane.MoveRight();
    // Modifier ce que l'on *voit*
    plane.show();
     // Temporiser
    Thread.Sleep(50);
}


