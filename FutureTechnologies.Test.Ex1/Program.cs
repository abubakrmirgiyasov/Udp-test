try
{
    // formula: floor * entrance * 4

    string[] arr = { "Ближняя слева", "Дальняя слева", "Дальняя справа", "Ближняя справа" };

    Console.Write("Введите количество этажей: ");
    int floors = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество подъездов: ");
    int entrances = int.Parse(Console.ReadLine()!);

    Console.Write("Введите номер квартиры: ");
    int apartment = int.Parse(Console.ReadLine()!);

    int apartmentsPerEntrance = floors * 4;
    int entranceNumber = (apartment - 1) / apartmentsPerEntrance + 1;
    int floorNumber = ((apartment - 1) % apartmentsPerEntrance) / 4 + 1;

    int position = (apartment - 1) % 4;

    if (apartment <= floors * entrances * 4)
        Console.WriteLine(string.Format("Подъезд: {0}, Этаж: {1}. Положение квартиры: {2}", entranceNumber, floorNumber, GetFloorPosition(position)));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message, ex);
}

static string GetFloorPosition(int number)
{
    return number switch
    {
        1 => "Ближняя слева",
        2 => "Дальняя слева",
        3 => "Дальняя справа",
        4 => "Ближняя справа",
        _ => "Квартира с таким номером нет в доме.",
    };
}
