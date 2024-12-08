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

    public int CountUniqueAntinodes(bool takeResonantHarmonicsIntoAccount)
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
                    var (antinodeRow, antinodeCol) = (rowB, colB);

                    do
                    {
                        antinodeRow += rowDiff;
                        antinodeCol += colDiff;
                        if (_antinodes.OutOfBounds(antinodeRow, antinodeCol))
                        {
                            break;
                        }

                        _antinodes.Set(antinodeRow, antinodeCol, '#');
                    } while (takeResonantHarmonicsIntoAccount);
                }
            }
        }

        if (takeResonantHarmonicsIntoAccount)
        {
            foreach (var (row, col) in AntennaLocations().Select(typeAndLocations => typeAndLocations.Value).SelectMany(list => list))
            {
                _antinodes.Set(row, col, '#');
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