using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PharmacyClass
{
    /// <summary>
    /// Название аптеки
    /// </summary>
    public string name;
    /// <summary>
    /// Название лекарства
    /// </summary>
    public string lecarstvo;
    /// <summary>
    /// Цена лекарства
    /// </summary>
    public int price;
    public PharmacyClass(string lecarstvo, int price)
    {
        this.lecarstvo = lecarstvo;
        this.price = price;
    }
    /// <summary>
    /// Список лекарст с ценами
    /// </summary>
    public List<PharmacyClass> lecar_name = new List<PharmacyClass>();
    public static void Show(string name)
    {
        Console.WriteLine(name);
    }
    public static void Info(string name, List<PharmacyClass> lecar_name)
    {
        Console.WriteLine("Название: " + name);
        Console.WriteLine("Список лекарств:");
        foreach (PharmacyClass z in lecar_name)
        {
            Console.WriteLine(z.lecarstvo + " " + z.price + " руб.");
        }
    }
    public static void MaxPrice(string name, List<PharmacyClass> lecar_name)
    {     
        lecar_name = lecar_name.OrderBy(x => x.price).ThenBy(y => y.lecarstvo).ToList();
        int size = lecar_name.Count;
        Console.WriteLine("Самое дорогое лекарство в аптеке " + name + " : "+ lecar_name[size-1].lecarstvo + ", стоимость: " +lecar_name[size-1].price + " руб.");
    }
    public static int sum = 0;
    public static void AllPrice(string name, List<PharmacyClass> lecar_name)
    {
        for (int i = 0; i < lecar_name.Count; i++)
        {
            sum += lecar_name[i].price;
        }
        Console.WriteLine("Стоимость всех лекарств в аптеке " + name + " сотавляет " + sum + " руб.");
    }
    
}
