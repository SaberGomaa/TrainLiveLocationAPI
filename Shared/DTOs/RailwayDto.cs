namespace Shared.DTOs
{
    public record RailwayDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? StartStation { get; set; }
        public string? LastStation { get; set; }

    }
    public record ReturnedRailwayDto
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? StartStation { get; set; }
        public string? LastStation { get; set; }

    }
}
