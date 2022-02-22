using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pharmacy
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
    public Pharmacy(string lecarstvo, int price)
    {
        this.lecarstvo = lecarstvo;
        this.price = price;
    }
}
