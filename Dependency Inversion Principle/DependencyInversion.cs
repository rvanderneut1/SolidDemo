public class Player{

    private readonly IWeapon _weapon;

    public Player(IWeapon weapon)
    {
        _weapon = weapon;
    }

    public void Attack()
    {
        _weapon.Fire();
    }

}

public class DiscoGun : IWeapon
{
    public void Fire()
    {
        Console.WriteLine("Disco Gun fires");
    }
}

public class LaserGun : IWeapon
{
    public void Fire()
    {
        Console.WriteLine("Laser Gun fires");
    }
}

public class waterGun : IWeapon
{
    public void Fire()
    {
        Console.WriteLine("Water Gun fires");
    }
}