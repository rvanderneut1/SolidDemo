public enum PaymentMethod
{
    CreditCard,
    PayPal
}
public class PaymentService
{

    public void MakePayment(decimal amount, PaymentMethod paymentMethod)
    {
        switch(paymentMethod){
            case PaymentMethod.CreditCard:
                Console.WriteLine($"Processing credit card payment of {amount:C}");
                break;
            case PaymentMethod.PayPal:
                Console.WriteLine($"Processing PayPal payment of {amount:C}");
                break;
            case PaymentMethod.CreditCard:
                Console.WriteLine($"Processing credit card payment of {amount:C}");
                break;
        }
        
    }
}