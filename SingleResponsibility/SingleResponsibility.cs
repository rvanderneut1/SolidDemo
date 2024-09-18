public decimal CalculatePrice(decimal[] items, decimal taxPercentage, decimal tipPercentage)
{
    decimal totalPrice = CalculateTotalPrice(items);
    decimal taxAmount = CalculateTaxAmount(totalPrice, taxPercentage);
    decimal tipAmount = CalculateTipAmount(totalPrice, tipPercentage);

    totalPrice += taxAmount + tipAmount;

    return totalPrice;
}