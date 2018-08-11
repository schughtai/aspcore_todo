namespace aspcore.Models
{
    public class TaskDetails
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        /*public TaskDetails(int id, string title, string description)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
        }*/
    }
}