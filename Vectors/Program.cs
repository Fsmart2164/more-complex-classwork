using System.Numerics;
using System.Text;

class program
{
    static void Main(string[] args)
    {
        Vector2 v1 = new Vector2();
        v1.X = 1;
        v1.Y = 1;
        Vector2 v2 = new Vector2();
        v2.X = 2;
        v2.Y = 5;
        Vector2 v3 = -v1 * v2;

        MyVector v4 = new MyVector(new int[] { 2, 3 });
        MyVector v5 = new MyVector(new int[] { 1, 5 });

        Console.WriteLine(v1);
        Console.WriteLine(v2);
        Console.WriteLine(v3);
        MyVector yes = (-v4);
        Console.WriteLine(yes);
        Console.WriteLine(v5.ToString());
        Console.WriteLine((yes * v5).ToString());
    }
}

public class MyVector
{
    public int[] values;
    private int length;
    public MyVector(int size)
    {
        values = new int[size];
        length = size;
        WriteNewVector();
    }
    public MyVector()
    {
        values = new int[2];
        length = 2;
        WriteNewVector();
    }
    public MyVector(int[] v)
    {
        this.length = v.Length;
        this.values = v;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<");
        for (int i = 0; i < length; i++)
        {
            if (i != 0) sb.Append(", ");
            sb.Append(values[i]);
        }
        sb.Append(">");
        return sb.ToString();
    }
    private void WriteNewVector()
    {
        for (int i = 0; i < length; i++)
        {
            values[i] = 0;
        }
    }

    public static MyVector operator +(MyVector v1, MyVector v2)
    {

        var vectorpair = SetupOperators(v1,v2);

        int size = vectorpair.Item1.Length;
        MyVector output = new MyVector(size);

        for (int i = 0; i < size; i++)
        {
            output.values[i] = vectorpair.Item1[i] + vectorpair.Item2[i];
        }
        return output;
    }
    public static bool operator ==(MyVector v1, MyVector v2)
    {
        var vectorpair = SetupOperators(v1, v2);

        for (int o = 0; o < vectorpair.Item1.Length; o++)
        {
            if (vectorpair.Item1[o] != vectorpair.Item2[o])
            {
                return false;
            }
        }
        return true;
    }
    public static MyVector operator *(MyVector v1, MyVector v2)
    {
        var vpair = SetupOperators(v1, v2);

        MyVector ret = new MyVector(vpair.Item1.Length);
        for (int o = 0; o < vpair.Item1.Length; o++)
        {
            ret.values[o] = vpair.Item1[o] * vpair.Item2[o];
        }
        return ret;
    }
    public static MyVector operator -(MyVector v1)
    {
        MyVector ouput = new MyVector(v1.values);
        for (int o = 0; o < v1.length; o++)
        {
            int num = ouput.values[o];
            int insert = num - num * 2;
            ouput.values[o] = insert;
        }
        return ouput;
    }
    public static bool operator !=(MyVector v1, MyVector v2)
    {
        if (v1 == v2) return false;
        return true;
    }
    private static (int[], int[]) SetupOperators(MyVector v1, MyVector v2)
    {
        (int[], int[]) ret; 
        int[] firstvalues = v1.values;
        int[] secondvalues = v2.values;
        if (firstvalues.Length != secondvalues.Length)
        {
            throw new Exception("different lengths");
        }
        ret.Item1 = firstvalues;
        ret.Item2 = secondvalues;
        return ret;
    }

    
}