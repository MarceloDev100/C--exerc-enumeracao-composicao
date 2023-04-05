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




