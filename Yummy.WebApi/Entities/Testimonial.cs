﻿namespace Yummy.WebApi.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Fullname { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
