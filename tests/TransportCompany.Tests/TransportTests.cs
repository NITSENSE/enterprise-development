using TransportCompany.Domain.Data;
using TransportCompany.Domain.Shared.Enums;

namespace TransportCompany.Tests;

public class TransportTests
{
    /// <summary>
    /// 1. Вывести информацию обо всех клиентах, заказывавших перевозку
    /// на транспорте указанной модели, упорядочить по ФИО
    /// </summary>
    [Fact]
    public void GetClientsByVehicleModel()
    {
        const string modelName = "Volvo FH";

        var expected = new[]
        {
            "АО «ТехноСервис»",
            "ИП Сидоров С.С.",
            "ООО «МебельГрад»"
        };

        var result = TransportTestData.Trips
            .Where(trip => trip.Vehicle.Model.Name == modelName)
            .Select(trip => trip.Client)
            .DistinctBy(client => client.Id)
            .OrderBy(client => client.Name)
            .Select(client => client.Name)
            .ToArray();

        Assert.Equal(expected, result);
    }

    /// <summary>
    /// 2. Вывести информацию о транспортных средствах, находящихся в рейсе
    /// </summary>
    [Fact]
    public void GetVehiclesOnTrip()
    {
        var expectedPlates = new[]
        {
            "А001АА 77",
            "М001ММ 77",
            "С001СС 77"
        };

        var result = TransportTestData.Trips
            .Where(trip => trip.IsActive)
            .Select(trip => trip.Vehicle)
            .DistinctBy(vehicle => vehicle.Id)
            .OrderBy(vehicle => vehicle.LicensePlate)
            .Select(vehicle => vehicle.LicensePlate)
            .ToArray();

        Assert.Equal(expectedPlates, result);
    }

    /// <summary>
    /// 3. Вывести топ 5 водителей по количеству рейсов
    /// </summary>
    [Fact]
    public void GetTop5DriversByTripCount()
    {
        var expected = new[]
        {
            (PassportNumber: "4501 123456", TripCount: 5),
            (PassportNumber: "4502 234567", TripCount: 4),
            (PassportNumber: "4503 345678", TripCount: 3),
            (PassportNumber: "4504 456789", TripCount: 2),
            (PassportNumber: "4505 567890", TripCount: 1)
        };

        var result = TransportTestData.Trips
            .GroupBy(trip => trip.Driver)
            .OrderByDescending(group => group.Count())
            .ThenBy(group => group.Key.PassportNumber)
            .Take(5)
            .Select(group => (
                PassportNumber: group.Key.PassportNumber,
                TripCount: group.Count()))
            .ToArray();

        Assert.Equal(expected, result);
    }

    /// <summary>
    /// 4. Для каждого транспортного средства вывести число рейсов
    /// </summary>
    [Theory]
    [InlineData("А001АА 77", 1)]
    [InlineData("А002АА 77", 1)]
    [InlineData("В001ВВ 77", 1)]
    [InlineData("С001СС 77", 3)]
    [InlineData("Е001ЕЕ 77", 1)]
    [InlineData("К001КК 77", 1)]
    [InlineData("М001ММ 77", 1)]
    [InlineData("Н001НН 77", 1)]
    [InlineData("О001ОО 77", 1)]
    [InlineData("Р001РР 77", 2)]
    [InlineData("Т001ТТ 77", 1)]
    [InlineData("У001УУ 77", 1)]
    public void GetTripCountForEachVehicle(string licensePlate, int expectedTripCount)
    {
        var tripCounts = TransportTestData.Trips
            .GroupBy(trip => trip.Vehicle.LicensePlate)
            .ToDictionary(
                group => group.Key,
                group => group.Count());

        var actualTripCount = tripCounts.GetValueOrDefault(licensePlate);

        Assert.Equal(expectedTripCount, actualTripCount);
    }

    /// <summary>
    /// 5. Вывести топ 5 клиентов по сумме затрат на перевозки
    /// </summary>
    [Fact]
    public void GetTop5ClientsByTotalCost()
    {
        var expected = new (string Name, decimal TotalCost)[]
        {
            ("ООО «Ромашка»",       300_000m),
            ("ИП Сидоров С.С.",     250_000m),
            ("ИП Петров П.П.",      180_000m),
            ("АО «ТехноСервис»",    150_000m),
            ("ИП Иванов И.И.",      135_000m)
        };

        var result = TransportTestData.Trips
            .GroupBy(trip => trip.Client)
            .Select(group => new
            {
                Client = group.Key,
                TotalCost = group.Sum(trip => trip.Cost)
            })
            .OrderByDescending(x => x.TotalCost)
            .Take(5)
            .Select(x => (
                Name: x.Client.Name,
                TotalCost: x.TotalCost))
            .ToArray();

        Assert.Equal(expected, result);
    }
}