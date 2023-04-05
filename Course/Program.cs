/*
  Enumerações: Tipo valor representado por um conjunto de constantes relacionadas.
  palavra chave: enum
  -vantagem: semântica(entendimento), 
  -código legível,
  -auxiliado pelo compilador(evita erros).
*/

using Course.Entities;
using Course.Entities.Emums;

Order order = new Order { 
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

// Assuming there is an enumerated type and I want to convert it to string
// enumerated type -> string
string txt = OrderStatus.PendingPayment.ToString();

// Printing PendingPayment in string format
Console.WriteLine(txt);

// What if was the opposite? There is a string and I want to convert it to an
// enumerated type
// string -> enumerated type
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
Console.WriteLine(os);

// More ways to convert string to an enumerated type
os = (OrderStatus) Enum.Parse(typeof(OrderStatus), "Shipped");
Console.WriteLine(os);

Enum.TryParse("Processing", out os);
Console.WriteLine(os);

