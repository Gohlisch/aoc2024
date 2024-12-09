namespace Day09;

public class DiskMap
{
    private List<Memory> Memory { get; } = new();

    public DiskMap(string diskMap)
    {
        int idGenerator = 0;
        for (int i = 0; i < diskMap.Length; i++)
        {
            bool isFile = i % 2 == 0;
            int size = int.Parse(diskMap[i].ToString());
            if(size == 0) continue;
            
            Memory.Add(
                new(size,
                    isFile ? idGenerator++ : null,
                    isFile ? MemoryState.Allocated : MemoryState.Free
                )
            );
        }
    }
    
    
}