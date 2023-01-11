namespace YoutubeUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private static IEnumerable<Tag> GetTags() =>
        new List<Tag>()
        {
            new Tag("Все"),
            new Tag("Видеоигры"),
            new Tag("Дикая природа"),
            new Tag("Сейчас в эфире"),
            new Tag("Анимация"),
            new Tag("Экшен и приключения"),
            new Tag("Ремесла"),
            new Tag("Последние опубликованные видео"),
            new Tag("Просмотрено"),
            new Tag("Новое для вас"),
            new Tag("Отправить отзыв"),
        };
}

public record struct Tag(string Name);

