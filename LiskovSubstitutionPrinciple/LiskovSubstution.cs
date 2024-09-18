
public class Car{
    public string FuelCar(ICar car){
        return car.TankGas();
    }    
}

public class Truck : Car, ITankGas
{
    public override Tankgas(){
        return "Im tanking Gas in my truck"
    }
}

public class BMW : Car, ITankGas
{
    public override TankGas(){
        return "Im tanking my Beamer"
    }
}

public class Tesla : Car
{
   // Een Tesla is wel een auto maar kan niet tanken
}


public interface ITankGas
{
    string TankGas();
}