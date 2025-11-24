// See https://aka.ms/new-console-template for more information
using LowLevelDesign.OOPS;

Console.WriteLine("Hello, World!");
PaymentService paymentService = new PaymentService();
paymentService.AddPaymentMethod("JohnCreditCardId", new CreditCard("123", "John Doe"));
paymentService.AddPaymentMethod("JaneDebitCardId", new DebitCard("456", "John Doe"));
paymentService.AddPaymentMethod("AliceUPIId", new UPI("JohnDoe@upi"));
paymentService.MakePayment("JohnCreditCardId");
paymentService.MakePayment("JaneDebitCardId");
paymentService.MakePayment("AliceUPIId");