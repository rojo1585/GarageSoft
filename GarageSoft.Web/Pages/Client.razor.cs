using GarageSoft.Shared.DTOs.Client;
using GarageSoft.Web.Components;
using GarageSoft.Web.Services;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace GarageSoft.Web.Pages;

public partial class Client
{
    [Inject] public DialogService DialogService { get; set; }
    [Inject] public NotificationService NotificationService { get; set; }
    [Inject] public IClientDataService ClientService { get; set; }

    private async Task OnAddCustomer()
    {
        var result = await DialogService.OpenAsync<AddClientDialog>("Nuevo Cliente");

        if (result != null)
        {
            CreateClientDto nuevoCliente = (CreateClientDto)result;

            bool exito = await ClientService.CreateClientAsync(nuevoCliente);

            if (exito)
            {
                NotificationService.Notify(new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Éxito" });
            }
            else
            {
                NotificationService.Notify(new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Error" });
            }
        }
    }
}