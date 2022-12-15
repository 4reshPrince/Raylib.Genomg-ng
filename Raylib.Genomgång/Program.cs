global using Raylib_cs;

Raylib.InitWindow(800, 600, "Spel");
Raylib.SetTargetFPS(60);

Area grasslands = new Area();

while (!Raylib.WindowShouldClose())
{
    // LOGIK
    grasslands.Update();

    // GRAFIK
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    grasslands.Draw();

    Raylib.EndDrawing();


}