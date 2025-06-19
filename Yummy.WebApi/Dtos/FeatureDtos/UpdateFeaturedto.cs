namespace Yummy.WebApi.Dtos.FeatureDtos
{
    public class UpdateFeaturedto
    {
        public int FeatureId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public string ImageUrl { get; set; }
    }
}
