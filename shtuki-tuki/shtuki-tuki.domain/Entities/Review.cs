using System;

namespace shtuki_tuki.domain.Entities
{
    public class Review
    {
        public int Id { get; set; }

        public string LinkPhotoUserReview { get; set; }

        public string NameUserReview { get; set; }

        public string CityUserReview { get; set; }

        public string LinkUserReview { get; set; }

        public string ReviewText { get; set; }

        public DateTime DateReview { get; set; }
    }
}