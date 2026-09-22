namespace TransportCompany.Domain.Models;

/// <summary>
/// Транспортное средство
/// </summary>
public class Vehicle
{
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Государственный регистрационный номер
    /// </summary>
    public required string LicensePlate { get; set; }

    /// <summary>
    /// Марка
    /// </summary>
    public required string Brand { get; set; }

    /// <summary>
    /// Грузоподъёмность в тоннах
    /// </summary>
    public double Capacity { get; set; }

    /// <summary>
    /// Модель транспортного средства
    /// </summary>
    public required VehicleModel Model { get; set; }
}