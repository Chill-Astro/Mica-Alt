namespace Mica_Alt_by_Chill_Astro.Activation;

public interface IActivationHandler
{
    bool CanHandle(object args);

    Task HandleAsync(object args);
}
