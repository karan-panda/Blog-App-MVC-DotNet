namespace Blog_App.Models.ViewModels
{
    // For model binding in the Add action method of the AdminTagsController
    public class AddTagRequest
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
