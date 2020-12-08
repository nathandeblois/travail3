using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationTerrain.Donnees
{
    public class Terrain_DAO : ITerrain
    {
        public List<Terrain> terrains;
        public Terrain_DAO()
        {
            var terrainDeTennis = new TerrainDeTennis();
            terrains.Add(terrainDeTennis);
            var terrainDeTennis2 = new TerrainDeTennis();
            terrains.Add(terrainDeTennis2);
            var terrainDeTennis3 = new TerrainDeTennis();
            terrains.Add(terrainDeTennis3);

            var patinoire = new Patinoire();
            terrains.Add(patinoire);

            var terrainDeBasketball = new TerrainDeBasketball();
            terrains.Add(terrainDeTennis);

            var terrainDeVolleyball = new TerrainDeVolleyball();
            terrains.Add(terrainDeVolleyball);
            var terrainDeVolleyball2 = new TerrainDeVolleyball();
            terrains.Add(terrainDeVolleyball2);

            var terrainDeBadminton = new TerrainDeBadminton();
            terrains.Add(terrainDeBadminton);
            var terrainDeBadminton2 = new TerrainDeBadminton();
            terrains.Add(terrainDeBadminton2);
            var terrainDeBadminton3 = new TerrainDeBadminton();
            terrains.Add(terrainDeBadminton3);
            var terrainDeBadminton4 = new TerrainDeBadminton();
            terrains.Add(terrainDeBadminton4);
        }
        public List<Terrain> GetAllTerrains()
        {
            return terrains;
        }
    }
}
