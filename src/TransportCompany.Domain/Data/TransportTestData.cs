using TransportCompany.Domain.Models;
using TransportCompany.Domain.Shared.Enums;

namespace TransportCompany.Domain.Data;

/// <summary>
/// Тестовые данные для системы транспортной компании
/// </summary>
public static class TransportTestData
{
    /// <summary>
    /// Справочник моделей транспортных средств
    /// </summary>
    public static List<VehicleModel> VehicleModels { get; } =
    [
        new() { Id = 1,  Name = "ГАЗель Next",     BodyType = BodyType.Tent,         BodyVolume = 10.5 },
        new() { Id = 2,  Name = "КАМАЗ 5490",      BodyType = BodyType.Tent,         BodyVolume = 60.0 },
        new() { Id = 3,  Name = "Volvo FH",        BodyType = BodyType.Refrigerator, BodyVolume = 80.0 },
        new() { Id = 4,  Name = "Scania R450",     BodyType = BodyType.Container,    BodyVolume = 75.0 },
        new() { Id = 5,  Name = "MAN TGX",         BodyType = BodyType.Flatbed,      BodyVolume = 70.0 },
        new() { Id = 6,  Name = "Mercedes Actros", BodyType = BodyType.Refrigerator, BodyVolume = 82.0 },
        new() { Id = 7,  Name = "Isuzu Elf",       BodyType = BodyType.Tent,         BodyVolume = 20.0 },
        new() { Id = 8,  Name = "Ford Transit",    BodyType = BodyType.Tent,         BodyVolume = 12.0 },
        new() { Id = 9,  Name = "Renault Premium", BodyType = BodyType.Tank,         BodyVolume = 55.0 },
        new() { Id = 10, Name = "DAF XF",          BodyType = BodyType.Container,    BodyVolume = 78.0 }
    ];

    /// <summary>
    /// Список водителей
    /// </summary>
    public static List<Driver> Drivers { get; } =
    [
        new() { Id = 1,  PassportNumber = "4501 123456", LastName = "Иванов",   FirstName = "Иван",    Patronymic = "Иванович",   Experience = 15, LicenseCategory = LicenseCategory.CE },
        new() { Id = 2,  PassportNumber = "4502 234567", LastName = "Петров",   FirstName = "Пётр",    Patronymic = "Петрович",   Experience = 12, LicenseCategory = LicenseCategory.CE },
        new() { Id = 3,  PassportNumber = "4503 345678", LastName = "Сидоров",  FirstName = "Сидор",   Patronymic = "Сидорович",  Experience = 8,  LicenseCategory = LicenseCategory.C },
        new() { Id = 4,  PassportNumber = "4504 456789", LastName = "Кузнецов", FirstName = "Алексей", Patronymic = "Иванович",   Experience = 20, LicenseCategory = LicenseCategory.CE },
        new() { Id = 5,  PassportNumber = "4505 567890", LastName = "Смирнов",  FirstName = "Дмитрий", Patronymic = "Олегович",   Experience = 5,  LicenseCategory = LicenseCategory.C },
        new() { Id = 6,  PassportNumber = "4506 678901", LastName = "Волков",   FirstName = "Андрей",  Patronymic = "Сергеевич",  Experience = 7,  LicenseCategory = LicenseCategory.CE },
        new() { Id = 7,  PassportNumber = "4507 789012", LastName = "Морозов",  FirstName = "Сергей",  Patronymic = "Павлович",   Experience = 10, LicenseCategory = LicenseCategory.C },
        new() { Id = 8,  PassportNumber = "4508 890123", LastName = "Новиков",  FirstName = "Олег",    Patronymic = "Викторович", Experience = 3,  LicenseCategory = LicenseCategory.B },
        new() { Id = 9,  PassportNumber = "4509 901234", LastName = "Фёдоров",  FirstName = "Максим",  Patronymic = "Игоревич",   Experience = 9,  LicenseCategory = LicenseCategory.CE },
        new() { Id = 10, PassportNumber = "4510 012345", LastName = "Егоров",   FirstName = "Никита",  Patronymic = "Романович",  Experience = 4,  LicenseCategory = LicenseCategory.C }
    ];

    /// <summary>
    /// Список клиентов
    /// </summary>
    public static List<Client> Clients { get; } =
    [
        new() { Id = 1,  Name = "ООО «Ромашка»",        Phone = "+7 900 000-00-01" },
        new() { Id = 2,  Name = "ИП Иванов И.И.",       Phone = "+7 900 000-00-02" },
        new() { Id = 3,  Name = "ООО «Василёк»",        Phone = "+7 900 000-00-03" },
        new() { Id = 4,  Name = "АО «ТехноСервис»",     Phone = "+7 900 000-00-04" },
        new() { Id = 5,  Name = "ООО «Логистик Плюс»",  Phone = "+7 900 000-00-05" },
        new() { Id = 6,  Name = "ИП Петров П.П.",       Phone = "+7 900 000-00-06" },
        new() { Id = 7,  Name = "ООО «СтройМатериалы»", Phone = "+7 900 000-00-07" },
        new() { Id = 8,  Name = "ООО «АгроТрейд»",      Phone = "+7 900 000-00-08" },
        new() { Id = 9,  Name = "ИП Сидоров С.С.",      Phone = "+7 900 000-00-09" },
        new() { Id = 10, Name = "ООО «МебельГрад»",     Phone = "+7 900 000-00-10" }
    ];

    /// <summary>
    /// Список транспортных средств
    /// </summary>
    public static List<Vehicle> Vehicles { get; } =
    [
        new() { Id = 1,  LicensePlate = "А001АА 77", Brand = "ГАЗ",      Capacity = 1.5,  Model = VehicleModels[0] },
        new() { Id = 2,  LicensePlate = "А002АА 77", Brand = "ГАЗ",      Capacity = 1.5,  Model = VehicleModels[0] },
        new() { Id = 3,  LicensePlate = "В001ВВ 77", Brand = "КАМАЗ",    Capacity = 20.0, Model = VehicleModels[1] },
        new() { Id = 4,  LicensePlate = "С001СС 77", Brand = "Volvo",    Capacity = 20.0, Model = VehicleModels[2] },
        new() { Id = 5,  LicensePlate = "Е001ЕЕ 77", Brand = "Scania",   Capacity = 25.0, Model = VehicleModels[3] },
        new() { Id = 6,  LicensePlate = "К001КК 77", Brand = "MAN",      Capacity = 20.0, Model = VehicleModels[4] },
        new() { Id = 7,  LicensePlate = "М001ММ 77", Brand = "Mercedes", Capacity = 20.0, Model = VehicleModels[5] },
        new() { Id = 8,  LicensePlate = "Н001НН 77", Brand = "Isuzu",    Capacity = 5.0,  Model = VehicleModels[6] },
        new() { Id = 9,  LicensePlate = "О001ОО 77", Brand = "Ford",     Capacity = 3.0,  Model = VehicleModels[7] },
        new() { Id = 10, LicensePlate = "Р001РР 77", Brand = "Renault",  Capacity = 18.0, Model = VehicleModels[8] },
        new() { Id = 11, LicensePlate = "Т001ТТ 77", Brand = "DAF",      Capacity = 20.0, Model = VehicleModels[9] },
        new() { Id = 12, LicensePlate = "У001УУ 77", Brand = "ГАЗ",      Capacity = 1.5,  Model = VehicleModels[0] }
    ];

    /// <summary>
    /// Список рейсов
    /// </summary>
    public static List<Trip> Trips { get; } =
    [
        new() { Id = 1,  Driver = Drivers[0], Vehicle = Vehicles[0],  Client = Clients[0],  DeparturePoint = "Москва", DepartureDate = new DateTime(2026, 1, 10), DestinationPoint = "Санкт-Петербург", CargoWeight = 15, Cost = 120_000m, Status = TripStatus.InProgress },
        new() { Id = 2,  Driver = Drivers[0], Vehicle = Vehicles[1],  Client = Clients[1],  DeparturePoint = "Москва", DepartureDate = new DateTime(2026, 1, 12), DestinationPoint = "Казань",          CargoWeight = 18, Cost =  90_000m, Status = TripStatus.Completed  },
        new() { Id = 3,  Driver = Drivers[0], Vehicle = Vehicles[2],  Client = Clients[2],  DeparturePoint = "СПб",    DepartureDate = new DateTime(2026, 1, 15), DestinationPoint = "Москва",          CargoWeight = 20, Cost =  80_000m, Status = TripStatus.Completed  },
        new() { Id = 4,  Driver = Drivers[0], Vehicle = Vehicles[3],  Client = Clients[3],  DeparturePoint = "Москва", DepartureDate = new DateTime(2026, 2, 1),  DestinationPoint = "Сочи",            CargoWeight = 22, Cost = 150_000m, Status = TripStatus.InProgress },
        new() { Id = 5,  Driver = Drivers[0], Vehicle = Vehicles[3],  Client = Clients[8],  DeparturePoint = "Москва", DepartureDate = new DateTime(2026, 2, 22), DestinationPoint = "Минск",           CargoWeight = 30, Cost = 250_000m, Status = TripStatus.Planned    },
        new() { Id = 6,  Driver = Drivers[1], Vehicle = Vehicles[4],  Client = Clients[0],  DeparturePoint = "Казань", DepartureDate = new DateTime(2026, 2, 3),  DestinationPoint = "Уфа",             CargoWeight = 10, Cost =  50_000m, Status = TripStatus.Completed  },
        new() { Id = 7,  Driver = Drivers[1], Vehicle = Vehicles[5],  Client = Clients[4],  DeparturePoint = "Уфа",    DepartureDate = new DateTime(2026, 2, 5),  DestinationPoint = "Пермь",           CargoWeight = 12, Cost =  60_000m, Status = TripStatus.Completed  },
        new() { Id = 8,  Driver = Drivers[1], Vehicle = Vehicles[6],  Client = Clients[5],  DeparturePoint = "Пермь",  DepartureDate = new DateTime(2026, 2, 7),  DestinationPoint = "Москва",          CargoWeight = 25, Cost = 180_000m, Status = TripStatus.InProgress },
        new() { Id = 9,  Driver = Drivers[1], Vehicle = Vehicles[7],  Client = Clients[6],  DeparturePoint = "Москва", DepartureDate = new DateTime(2026, 2, 10), DestinationPoint = "Тула",            CargoWeight = 8,  Cost =  30_000m, Status = TripStatus.Completed  },
        new() { Id = 10, Driver = Drivers[2], Vehicle = Vehicles[8],  Client = Clients[7],  DeparturePoint = "Тула",   DepartureDate = new DateTime(2026, 2, 12), DestinationPoint = "Калуга",          CargoWeight = 5,  Cost =  25_000m, Status = TripStatus.Completed  },
        new() { Id = 11, Driver = Drivers[2], Vehicle = Vehicles[9],  Client = Clients[1],  DeparturePoint = "Калуга", DepartureDate = new DateTime(2026, 2, 14), DestinationPoint = "Брянск",          CargoWeight = 9,  Cost =  45_000m, Status = TripStatus.Completed  },
        new() { Id = 12, Driver = Drivers[2], Vehicle = Vehicles[10], Client = Clients[2],  DeparturePoint = "Брянск", DepartureDate = new DateTime(2026, 2, 16), DestinationPoint = "Орёл",            CargoWeight = 7,  Cost =  35_000m, Status = TripStatus.Completed  },
        new() { Id = 13, Driver = Drivers[3], Vehicle = Vehicles[11], Client = Clients[9],  DeparturePoint = "Орёл",   DepartureDate = new DateTime(2026, 2, 18), DestinationPoint = "Курск",           CargoWeight = 6,  Cost =  28_000m, Status = TripStatus.Completed  },
        new() { Id = 14, Driver = Drivers[3], Vehicle = Vehicles[3],  Client = Clients[9],  DeparturePoint = "Курск",  DepartureDate = new DateTime(2026, 2, 20), DestinationPoint = "Белгород",        CargoWeight = 11, Cost =  55_000m, Status = TripStatus.Completed  },
        new() { Id = 15, Driver = Drivers[4], Vehicle = Vehicles[9],  Client = Clients[0],  DeparturePoint = "Москва", DepartureDate = new DateTime(2026, 2, 25), DestinationPoint = "Сочи",            CargoWeight = 12, Cost = 130_000m, Status = TripStatus.Planned    }
    ];
}