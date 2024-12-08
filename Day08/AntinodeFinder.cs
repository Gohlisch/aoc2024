using Day04;

namespace Day08;

public class AntiNodeFinder
{
    private readonly Grid _antennas;
    private readonly Grid _antinodes; 

    public AntiNodeFinder(Grid antennas)
    {
        _antennas = antennas;
        _antinodes = new Grid(_antennas.Rows, _antennas.Cols, '.');
    }

    public int CountUniqueAntinodes()
    {
        foreach (List<(int, int)> locations in AntennaLocations().Select(typeAndLocations => typeAndLocations.Value))
        {
            foreach ((int, int) locationA in locations)
            {
                foreach ((int, int) locationB in locations)
                {
                    if(locationA.Equals(locationB)) continue;
                    var (rowA, colA) = locationA;
                    var (rowB, colB) = locationB;

                    var (rowDiff, colDiff) = (rowB - rowA, colB - colA);
                    if (_antinodes.OutOfBounds(rowB + rowDiff, colB + colDiff))
                    {
                     continue;   
                    }
                    
                    _antinodes.Set(rowB + rowDiff, colB + colDiff, '#');
                }
            }
        }

        return _antinodes.FindAllLocations('#').Count;
    }

    private Dictionary<char, List<(int, int)>> AntennaLocations()
    {
        Dictionary<char, List<(int, int)>> locations = new();

        foreach (char antennaType in "abcdefghijklnmopqrstuvwxyzABCDEFGHIJKLNMOPQRSTUVWXYZ0123456789")
        {
            locations[antennaType] = _antennas.FindAllLocations(antennaType);
        }

        return locations;
    }
}