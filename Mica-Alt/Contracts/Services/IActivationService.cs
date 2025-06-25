namespace Mica_Alt.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
