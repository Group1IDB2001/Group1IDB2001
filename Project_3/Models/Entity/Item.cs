namespace Project_3.Models.Entity
{
    enum Genre
    {
        no_info = 0,
        literary_fiction = 1,
        mystery = 2,
        thriller = 3,
        horror = 4,
        historical = 5,
        romance = 6,
        western = 7,
        bildungsroman = 8,
        speculative_fiction = 9,
        science_fiction = 10,
        fantasy = 11,
        dystopyan = 12,
        magical_realism = 13,
        realist_literature = 14,
        subject_literature = 15
    }
    public class Item
    {
        public Guid ItemID { get; set; }
        public string ItemName { get; set; }
        public Guid CountryID { get; set; }

        public string? ItemDecription { get; set; }

        public string? ItemCover { get; set; }

        public int ItemYear { get; set; }
        public int[] Genres { get; set; }
        public Item (string Name,Guid Country,string Description,string Cover,int Year,int[] Genres)
        {
            ItemID=Guid.NewGuid();
            ItemName=Name;
            CountryID=Country;
            ItemDecription=Description;
            ItemCover=Cover;
            ItemYear=Year;
            this.Genres = Genres;
        }

    }
}
