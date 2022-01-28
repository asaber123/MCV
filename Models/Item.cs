namespace MVC.Models;

public class Item
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    //constructor that runns everytime there is an instance ofthe class. 
    public Item(){
        Id =1;
        Name = "Åsa";
    }
}
