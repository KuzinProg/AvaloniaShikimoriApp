using Avalonia;
using Avalonia.ReactiveUI;
using System;

namespace AvaloniaShikimoriApp
{
    // TODO: 1. Сделать возможность открывать окна внутри одного приложения
    // TODO: 2. Фильтрация по имени
    // TODO: 3. Фильтрация: 1. Годы 2. Продолжительность
    // TODO: 4. Сортировка всего списка + Не работает сортировка по имени
    // TODO: 5. Изучить авторизацию
    // TODO: 6. Пагинация
    // TODO: 7. 


    // TODO: 999: Получить длительность всех аниме в МИРЕ.
    class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace()
                .UseReactiveUI();
    }
}