namespace MapsterDemo;

public static class MapsterDemoHelper
{
    public static void BasicUsageWithAdapter(Author author)
    {
        // situation 1: map to new dto instance
        var authorInfoDto = author.Adapt<AuthorInfoDto>();
        Console.WriteLine(authorInfoDto);

        // situation 2: map to existing dto instance
        author.Category = Category.Angular;
        author.Age = 30;
        author.Adapt(authorInfoDto);
        Console.WriteLine(authorInfoDto);
        
        // situation 3: use IMapper explicitly
        IMapper mapper = new Mapper();
        author.Gender = "Male";
        author.Posts = new List<string> {".NET 7 from zero to hero", "Angular 15 from zero to hero"};
        author.Job = new Job {Id = 1, Title = "Senior Developer"};
        var authorInfoDtoWithMapper = mapper.Map<AuthorInfoDto>(author);
        Console.WriteLine(authorInfoDtoWithMapper);
    }

    public static void BasicUsageWithBuildAdapter(Author author)
    {
        var dto = author.BuildAdapter()
            .AddParameters("Category", Category.DotNet)
            .AdaptToType<AuthorInfoDto>();
        
        Console.WriteLine(dto);
    }
}