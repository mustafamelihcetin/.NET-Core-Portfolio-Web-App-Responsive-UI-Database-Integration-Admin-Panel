namespace MyPortfolioWebApp.DAL.Entities
{
    public class ToDoList
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
