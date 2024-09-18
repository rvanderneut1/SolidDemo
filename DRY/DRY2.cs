public float CalculateDistanceToGroceryStore(int x, int y , int x2, int y2)
{
   CalculateDistanceToWork(x)  ; 
   }


public float CalculateDistanceToWork(int x, int y , int x2, int y2)
{
    float distance = Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2));
}