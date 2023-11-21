using NetTopologySuite.Geometries;

namespace Turf.Net.Test;

[Collection("MeasurementTest")]
public class MeasurementTest
{
    [Fact]
    public void TestAlong()
    {
        var line = new LineString(new Coordinate[] { new Coordinate(-83, 30), new Coordinate(-84, 36), new Coordinate(-78, 41) });
        var along = Turf.Along(line, 200);

        Assert.Equal("POINT (-84 36)", along.ToText());
    }

    [Fact]
    public void TestArea()
    {
        var polygon = new Polygon(new LinearRing(new Coordinate[] {
            new Coordinate(125, -15),
            new Coordinate(113, -22),
            new Coordinate(154, -27),
            new Coordinate(144, -15),
            new Coordinate(125, -15),
        }));
        var a = Turf.Area(polygon);
        Assert.Equal(3339946239196.927, a);
    }
    [Fact]
    public void TestDistance()
    {
        var from = new Coordinate(-75.343, 39.984);
        var to = new Coordinate(-75.534, 39.123);
        var d = Turf.Distance(from, to);
        Assert.Equal(97.12922118967835, d);
    }
}