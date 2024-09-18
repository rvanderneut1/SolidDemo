public int CalculateTaxAmount(List<int> products) 
{
    int calculatedPrice = products.Sum();
    int taxAmount = calculatedPrice * 10 / 100;

    int tipAmount = calculatedPrice * 5 / 100;
 
    Restock(products);
    PutProductsInCart(products);

    return taxAmount;
}