namespace ProjectsStore.Core.Models;

public class Project
{
    public Project(Guid id, Guid authorId, bool isPublic, string title, string description, string gitUrl, string text)
    {
        Id = id;
        AuthorId = authorId;
        IsPublic = isPublic;
        Title = title;
        Description = description;
        GitUrl = gitUrl;
        Text = text;
    }

    public Guid Id { get; private set; }
    public Guid AuthorId { get; private set; }
    public bool IsPublic { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string GitUrl { get; set; }
    public string Text { get; set; }
    
    public List<Image> Images { get; set; } = new List<Image>();
    public List<CodeBlock> CodeBlocks { get; set; } = new List<CodeBlock>();
}