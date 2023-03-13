class Domino
{
    private int d1,d2;
    private int total;

    public Domino(int total)
    {
        Domino a = (0,1);
        Domino b = (2,3);
      total = d1+d2;
    }

    public void domino (int d1, int d2)
    {
      this.d1=d1;
      this.d2=d2;
    }
    public void Imprime()
    {
        
        Console.WriteLine(total);
    }
    public static Domino operator +(Domino a, Domino b)
    {
      int total = a.d1+b.d2;
      return new Domino(total);
    }

    public static implicit operator Domino((int, int) v)
    {
        throw new NotImplementedException();
    }
}
 class Program
{
    private static void Main(string[] args)
    {
        Console.ReadKey();

    }
}