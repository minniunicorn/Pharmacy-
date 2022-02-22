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
            Console.WriteLine(z.lecarstvo + " " + z.price);
        }
    }
    public static int MaxPrice(List<PharmacyClass>lecar_name)
    {     
        int size = lecar_name.Count;
        int max = lecar_name.Max(point => point.price);
        return max;
    }
    
}
