
using System.Drawing;
using System.Xml.Linq;

List<Flower> flowers = new List<Flower>();
flowers.Add(CarnationFabric.Create("Carnation", "blue", true, 3));
flowers.Add(RoseFabric.Create("Rose", "red", true, 8));
flowers.Add(RoseFabric.Create("Rose", "pink", false, 10));
flowers.Add(RoseFabric.Create("Rose", "pink", true, 16));
flowers.Add(CarnationFabric.Create("Carnation", "white", true, 5));
flowers.Add(CarnationFabric.Create("Carnation", "green", false, 2));
flowers.Add(CarnationFabric.Create("Carnation", "purple", true, 24));
BubbleSort(flowers);
Print();
void Print()
{
    foreach (Flower f in flowers)
    {
        Console.WriteLine(f.ToString());
    }
}
void BubbleSort(List<Flower> arr)
{
    static void BubbleSort(List<Flower> arr)
    {
        int n = arr.Count; for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j].petals > arr[j + 1].petals)
                {
                    Flower temp = arr[j];
                    arr[j] = arr[j + 1]; arr[j + 1] = temp;
                }
            }
        }
    }
}
class Flower
{
    public string name { get; set; }
    public string color { get; set; }
    public bool harmless { get; set; }
    public int petals { get; set; }


    public void Smell()
    {
        Console.WriteLine("this flower smells!");
    }

    public override string ToString()
    {
        return $"{name} {color}, {harmless}, {petals}";
    }
}

class Carnation : Flower
{
    public Carnation(string name, string color, bool harmless, int petals)
    {
        this.name = name;
        this.color = color;
        this.harmless = harmless;
        this.petals = petals;
        Console.WriteLine("Carnation created!");
    }

    public void grass()
    {
        Console.WriteLine("carnation has herbaceous or semi - herbaceous stem");
    }
}

class Rose : Flower
{
    public Rose(string color, string name, bool harmless, int petals)
    {
        this.name = name;
        this.color = color;
        this.harmless = harmless;
        this.petals = petals;
        Console.WriteLine("Rose created!");
    }

    public void thorns()
    {
        Console.WriteLine("the rose has thorns");
    }
}

static class CarnationFabric
{
    public static Carnation Create(string color, string name, bool harmless, int petals)
    {
        return new Carnation(color, name, harmless, petals);
    }
}

static class RoseFabric
{
    public static Rose Create(string color, string name, bool harmless, int petals)
    {
        return new Rose(color, name, harmless, petals);
    }
}