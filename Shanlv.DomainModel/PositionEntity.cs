namespace Shanlv.DomainModel
{
    public class PositionEntity : BaseEntity
    {
        /// <summary>
        /// 暂时先这么存储,经纬度以后说不定要合并
        /// </summary>
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}