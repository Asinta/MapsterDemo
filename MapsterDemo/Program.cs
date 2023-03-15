var author = new Author
{
    Id = 1,
    FirstName = "John",
    Surname = "Doe",
    Category = Category.DotNet,
    Address = new Address("Fake Street")
};

TypeAdapterConfig<Author, AuthorInfoDto>
    .NewConfig()
    .IgnoreIf(condition: (src, dto) => src.Job == null, dto => dto.JobTitle!, dto => dto.Category!)
    .Map(dest => dest.FullName, src => $"{src.FirstName} {src.Surname}");

TypeAdapterConfig.GlobalSettings
    .When((srcType, destType, mapType) => destType == typeof(AuthorInfoDto))
    .Ignore("Age")
    .IgnoreNullValues(true);

TypeAdapterConfig.GlobalSettings
    .When((srcType, destType, mapType) => mapType == MapType.Map)
    .IgnoreNullValues(true);

TypeAdapterConfig.GlobalSettings.ForDestinationType<AuthorInfoDto>()
    .AfterMapping(dest => Console.WriteLine($"{dest.FullName}"));

MapsterDemoHelper.BasicUsageWithAdapter(author);
// MapsterDemoHelper.BasicUsageWithBuildAdapter(author);