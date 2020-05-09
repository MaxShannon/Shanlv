namespace Shanlv.DomainModel
{
    public class Gate : PositionEntity
    {
        public string GateName { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }
    }
}