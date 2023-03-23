abstract class Musico
{
    public string Nombre{get; set;}
    


    //Constructor Músico
    public Musico (string n) {Nombre = n;}


    public void Saludar()
    {
        Console.WriteLine($"Hola soy {Nombre}");
    }

    //para poder compartir en otro método se debe poner virtual
    public abstract void Tocar();
     //esto es cuando en vez de abstract es virtual
     // {   Console.WriteLine($"{Nombre} está tocando su instrumento"); }

}

class Baterista:Musico
{
    //Constructor Baterista
    public string Bateria {get;set;}

    public  Baterista (string n, string b):base(n)
    {
        Bateria = b;
    }

    //override refedine un método virtual
    public override void Tocar()
    {
        Console.WriteLine($"{Nombre} está tocando su {Bateria}");
    }
}

class Bajista:Musico
{

    //Constructor Bajo
    public string Bajo {get;set;}

    public  Bajista (string n, string b):base(n)
    {
        Bajo = b;
    }

    //override refedine un método virtual
    public override void Tocar()
    {
        Console.WriteLine($"{Nombre} está tocando su {Bajo}");
    }
}

class Program
{
    private static void Main(string[] args)
    {
        List<Musico> banda = new List<Musico>();
        banda.Add(new Bajista("Natasha", "bajo"));
        banda.Add(new Baterista("Evlay", "Bateria"));
        foreach(var m in banda)
        {
        m.Tocar();
        }       

        Console.WriteLine(banda);
    }
}

//La clases abstractas solo pueden crear refrencias pero no objetos
//Abstract significa que la ces una clase demasiado general, pero si tiene sentido derivar otras clases con otros objetos