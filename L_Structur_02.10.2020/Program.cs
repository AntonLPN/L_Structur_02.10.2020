using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//структуры находяться здесь для доступа к ним в структурах. когда поместил перечисление в структуру то не могу к ней создать доступ
enum ArticleType
{
    Food = 1,
    Electrical_engineering,
    Construction_Materials
}
enum ClientType
{
    regular_customer = 1,
    client,
    VIP_client
}
enum PayType
{
    cash = 1,
    credit_card,
    pay_pas
}
struct Article
{
    string code_product;//код товара
    string name_product;
    int price_prodact;


    string type;//для передаи значения из перечисления
  

    //сеттеры геттеры

    public string SetGetTypeProdact
    {
        get { return type; }
        set {
            int num = Convert.ToInt32( value);
            type = Enum.GetName(typeof(ArticleType), num);

        }
    }

    

    public string GetSetCodeProduct
    {
        get { return code_product; }
        set { code_product=value; }
    }

    public string GetSetNameProdafct
    {
        get { return name_product; }
        set { name_product = value; }
    }
    
    public int GetSetPriceProduct
    {
        get { return price_prodact; }
        set => price_prodact = value;
    }

}

struct Client
{
    string name_client;
    int counter_of_orders;
    int total_price_orders;

    string client_type;


    //сеттеры геттеры
    public string SetGetTypeClient
    {
        get { return client_type; }
        set
        {
            int num = Convert.ToInt32(value);
            client_type = Enum.GetName(typeof(ClientType), num);

        }
    }




    public string NameClient
    {
        get { return name_client; }
        set { name_client = value; }
    }

   

    public int CounterOrders
    {
        get { return counter_of_orders; }
        set { counter_of_orders = value; }
    }
   
    public int TotalPrice
    {
        get { return total_price_orders; }
        set { total_price_orders = value; }
    }


}

struct RequestItem
{
    Article product;
  
    int counter_product;

   
    public int GetSetCounterProduct
    {
        get { return counter_product; }
        set { counter_product = value; }
    }

}

struct Request
{

    Article prodact;
    Client client;
    RequestItem requestItem;
    private string date_order;
    double sum_order;

    string pay_type;

    public string SetGetTypePay
    {
        get { return pay_type; }
        set
        {
            int num = Convert.ToInt32(value);
            pay_type = Enum.GetName(typeof(PayType), num);

        }
    }
    public string GetSetDateOrder
    {
        get { return date_order; }
        set { date_order  = value; }
    }

    public void Set_request()
    {
        //Console.Write("Введите код заказа :");
        //prodact.GetSetCodeProduct = Console.ReadLine();
        //Console.Write("Введите имя клиента :");
        //client.NameClient = Console.ReadLine();
        //Console.Write("Введите дату заказа :");
        //date_order = Console.ReadLine();
        //Console.Write("Введите название товара :");
        //prodact.GetSetNameProdafct = Console.ReadLine();
        //Console.Write("Введите стоимость товара за 1 шт. :");
        //prodact.GetSetPriceProduct = int.Parse(Console.ReadLine());
        //Console.Write("Введите количесвто единиц товара :");
        //requestItem.GetSetCounterProduct = int.Parse(Console.ReadLine());
        //Console.WriteLine(requestItem.GetSetCounterProduct);
        Console.WriteLine("-----------------ДЗ----------------------------------");
        Console.WriteLine("Выберите тип товара :");
        foreach (var item in Enum.GetValues(typeof(ArticleType)))
        {
            Console.WriteLine(" {0} - {1}",item,(int)item);
        }
        prodact.SetGetTypeProdact = Console.ReadLine() ;
        Console.WriteLine("Выбрана категория : {0}",prodact.SetGetTypeProdact);
        Console.WriteLine();
        Console.WriteLine("Выберите из списка перечисления степень важности клиента  :");
        foreach (var item in Enum.GetValues(typeof(ClientType)))
        {
            Console.WriteLine(" {0} - {1}", item, (int)item);
        }
        client.SetGetTypeClient = Console.ReadLine();
        Console.WriteLine("Выбрана категория : {0}", client.SetGetTypeClient);
        Console.WriteLine();
        Console.WriteLine("Выберите из списка перечисления способ оплаты  :");
        foreach (var item in Enum.GetValues(typeof(PayType)))
        {
            Console.WriteLine(" {0} - {1}", item, (int)item);
        }
        SetGetTypePay = Console.ReadLine();
        Console.WriteLine("Выбрана категория : {0}",SetGetTypePay);
    }

  

    public double SummOrder
    {
        get 
        {
            sum_order = prodact.GetSetPriceProduct * requestItem.GetSetCounterProduct;


            return sum_order;
        }
        set 
        {
            sum_order = value;
        }
    }


}

//Задание 1:
//Описать структуру Article, содержащую следующие поля:
//код товара; название товара; цену товара
//Задание 2:

// Описать структуру Client содержащую поля: 
//Код клиента; ФИО; адрес; телефон; количество заказов осуществленных клиентом; общая сумма заказов клиента
//Задание 3:

//Описать структуру RequestItem содержащую поля: товар; количество единиц товара
//Задание 4:

//Описать структуру Request содержащую поля: код заказа; клиент; дата заказа; перечень заказанных 
//    товаров; сумма заказа(реализовать вычисляемым свойством)

//Задание 1.
//Описать перечисление ArticleType определяющее типы товаров, и добавить соответствующее поле в структуру Article из задания №1 (лабораторной работы).
//Задание 2.
//Описать перечисление ClientType определяющее важность клиента, и добавить соответствующее поле в структуру Client из задания №2(лабораторной работы.
//Задание 3. 
//Описать перечисление PayType определяющее форму оплаты клиентом заказа, и добавить соответствующее поле в структуру Request из задания №4(лабораторной работы.


namespace L_Structur_02._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Request request=new Request();
            request.Set_request();
          

          
        }
    }
}
