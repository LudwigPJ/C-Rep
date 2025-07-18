using TestGame;
using TestGame.Ships;
using TestGame.Rout;

SpaceShip ship = new ScouShip(100, "Scout1", 50, 75, 200);
SpaceShip battleShip = new BattleShip(150, "Battle1", 100, 50, 300);
SpaceShip cargoShip = new CargoShip(80, "Cargo1", 60, 40, 150);

var ships = new List<SpaceShip> { ship, battleShip, cargoShip };
foreach (var s in ships)
{
    Console.WriteLine(s);
}

SpaceRout spaceRout = new NormalSpaceRout("NormalSpaceRout",1000);
SpaceRout spaceRout2 = new NebulaRoute("NebulaRoute", 1000);
SpaceRout spaceRout3 = new HyperspaceRoute("HyperspaceRoute", 1000);
SpaceRout spaceRout4 = new AsteroidFieldRoute("AsteroidFieldRoute", 1000);

Console.WriteLine();

var routes = new List<SpaceRout> { spaceRout, spaceRout2, spaceRout3, spaceRout4 };
foreach (var route in routes)
{
    Console.WriteLine(route.ToString(route, ship));   
    Console.WriteLine(route.ToString(route, battleShip));    
    Console.WriteLine(route.ToString(route, cargoShip));
    Console.WriteLine();
}
