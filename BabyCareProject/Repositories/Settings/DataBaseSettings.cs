namespace BabyCareProject.Repositories.Settings
{
    public class DataBaseSettings :IDataBaseSettings
    {
        public string ConnectionStrings { get; set; }
        public string DataBaseName { get; set; }
        public string InstructorCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
    }
}
