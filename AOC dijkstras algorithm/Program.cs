using System.Numerics;

internal class Program
{
    static void Main(string[] args)
    {
        (int, int) startpoint = (1, 1);
    }
    
}
internal class Dijkstras
{
    static int puzzlenum = 1352;
    private Vector2 source;
    private Vector2 destination;
    private Dictionary<Vector2, int> path = new Dictionary<Vector2, int>();
    private List<Vector2> Directions = new List<Vector2> { new Vector2(-1,0), new Vector2(1,0), new Vector2(0,-1), new Vector2(0,1)};
    private HashSet<Vector2> VistedCoords = new HashSet<Vector2>();
    private Queue<Vector2> visitingCoords = new Queue<Vector2>();
    public Dijkstras(Vector2 source, Vector2 destination)
    {
        this.source = source;
        this.destination = destination;
    }
    public int Run()
    {
        bool found = false;
        while (!found)
        {

        }
        return 0;
    }
    public void Visit(Vector2 current)
    {
        if (VistedCoords.Contains(current)) return;

        VistedCoords.Add(current);
        foreach (Vector2 direction in Directions)
        {
            if (isCubical(direction + current))
            {
                visitingCoords.Enqueue(direction + current);
            }
        }
    }
    static bool isCubical(Vector2 coord)
    {
        if ((coord.X < 0) || (coord.Y < 0))
        {
            return false;
        }
        // x*x + 3*x + 2*x*y + y + y*y
        int num = int.Parse(((coord.X * coord.X) + (3 * coord.X) + (2 * coord.X + coord.Y) + coord.Y + (coord.Y * coord.Y)).ToString());
        num += puzzlenum;
        string binary = Convert.ToString(num, 2);
        int count = 0;
        foreach (char c in binary)
        {
            if (c == '1')
            {
                count++;
            }
        }
        return count % 2 == 0;
    }
}