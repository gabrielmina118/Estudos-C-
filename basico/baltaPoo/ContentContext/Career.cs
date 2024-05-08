namespace BaltaPoo.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }
        //Expression body
        public int TotalCourse => Items.Count;
    }

}