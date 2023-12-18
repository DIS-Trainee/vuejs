namespace vue-project.Models
{
    public class PipeInfo
    {
        public int id { get; set; } 
        public string tag_no { get; set; } 
        public double pipe_size { get; set; }
        public string pipe_location { get; set; } 
        public DateTime installation_date { get; set; } 
        public int inspection_interval { get; set; } 
        public bool is_active { get; set; } 
    }
    public class PipeData
    {
        public int id { get; set; }
        public DateTime? installation_date { get; set; }
        public string? material_type { get; set; }
        public string? pipe_location { get; set; }


    }
}