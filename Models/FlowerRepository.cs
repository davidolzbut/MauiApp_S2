namespace MauiApp2.Models;

public static class FlowerRepository
{
    private static List<Flower> _flowers = new List<Flower>()
    {
        new Flower(1,"Rododendron", "Rhaphidophora tetrasperma"),
        new Flower(2,"Moinstera", "Philodendron Pink Princess 'M'"),
        new Flower(3,"Kokedama", "Kokedama Crassula Hobbit"),
        new Flower(4,"Lopatkovec", "Pilea Norfolk 'baby'"),


    };
    public static List<Flower> GetFlowers()
    {
        return _flowers;
    }

    public static Flower GetFlowerById(int flowerId)
    {
        return _flowers.FirstOrDefault(x => x.Id == flowerId);
    }
    
}