namespace GWebsite.AbpZeroTemplate.Core.Models.Dat
{
    public class Asset : FullAuditModel
    {
        public string Area { get; set; }
        public string Unitcode { get; set; }
        public string Areacode { get; set; }
        public string Transaction { get; set; }
        public string Assetcode { get; set; }
        public string Assetname { get; set; }
        public string Serinumber { get; set; }
        public int Originalprice { get; set; }
    }
}
