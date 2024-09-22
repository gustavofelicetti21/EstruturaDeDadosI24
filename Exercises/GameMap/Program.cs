using System.Text;
using GameMap;

Terrain.TerrainEnum[,] map =
{
    { Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.GRASS, Terrain.TerrainEnum.GRASS,
    Terrain.TerrainEnum.GRASS, Terrain.TerrainEnum.GRASS, Terrain.TerrainEnum.GRASS,
    Terrain.TerrainEnum.GRASS },
    { Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.GRASS, Terrain.TerrainEnum.GRASS,
    Terrain.TerrainEnum.GRASS, Terrain.TerrainEnum.GRASS, Terrain.TerrainEnum.GRASS,
    Terrain.TerrainEnum.GRASS },
    { Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.GRASS, Terrain.TerrainEnum.GRASS,
    Terrain.TerrainEnum.GRASS, Terrain.TerrainEnum.GRASS, Terrain.TerrainEnum.GRASS,
    Terrain.TerrainEnum.GRASS },
    { Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.GRASS, Terrain.TerrainEnum.GRASS,
    Terrain.TerrainEnum.GRASS, Terrain.TerrainEnum.GRASS, Terrain.TerrainEnum.GRASS,
    Terrain.TerrainEnum.GRASS },
    { Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.WALL, Terrain.TerrainEnum.WALL,
    Terrain.TerrainEnum.WALL },
    { Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.WALL, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND },
    { Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND, Terrain.TerrainEnum.WALL, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND },
    { Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER,
    Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER,
    Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WALL, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND },
    { Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER,
    Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER,
    Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WALL, Terrain.TerrainEnum.SAND,
    Terrain.TerrainEnum.SAND },
    { Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER,
    Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER,
    Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WALL, Terrain.TerrainEnum.WATER,
    Terrain.TerrainEnum.WATER },
    { Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER,
    Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WATER,
    Terrain.TerrainEnum.WATER, Terrain.TerrainEnum.WALL, Terrain.TerrainEnum.WATER,
    Terrain.TerrainEnum.WATER }
};
Console.OutputEncoding = UTF8Encoding.UTF8;
for (int row = 0; row < map.GetLength(0); row++)
{
    for (int column = 0; column < map.GetLength(1); column++)
    {
        Console.ForegroundColor = map[row, column].GetColor();
        Console.Write(map[row, column].GetChar() + " ");
    }
    Console.WriteLine();
}
Console.ForegroundColor = ConsoleColor.Gray;