class Domino
{
   public int d1;
   public int d2;

    public Domino(int d1, int d2)
    {
      this.d1=d1;
      this.d2=d2;
    }
    public static int operator + (Domino a, Domino b)
    {
      int suma=a.d1+a.d2+b.d1+b.d2;
      return suma;
    }
}
class Program
{
    private static void Main(string[] args)
    {
      Domino d1= new Domino (0,1);
      Domino d2= new Domino (2,3);
      int total= d1 + d2;
      Console.WriteLine(total);
    }
}