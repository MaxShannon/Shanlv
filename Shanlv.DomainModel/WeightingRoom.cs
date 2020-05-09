namespace Shanlv.DomainModel
{
    public class WeightingRoom : PositionEntity
    {
        public string WeightRoomName { get; set; }

        public string Ip { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }
    }
}