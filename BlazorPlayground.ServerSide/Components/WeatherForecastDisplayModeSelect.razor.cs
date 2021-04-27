using BlazorPlayground.ServerSide.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorPlayground.ServerSide.Components
{
    public partial class WeatherForecastDisplayModeSelect
    {
        [Parameter]
        public WeatherForecastDisplayModeSelection WeatherForecastDisplayModeSelection { get; set; }

        [Parameter]
        public EventCallback<WeatherForecastDisplayModeSelection> WeatherForecastDisplayModeSelectionChanged { get; set; }

        //protected void HandleInvalidSubmit()
        //{

        //}

        //protected void HandleValidSubmit()
        //{

        //}

        //protected void OnParamatersSet()
        //{

        //}

        private async Task ChangeDetailedSelection()
        {
            WeatherForecastDisplayModeSelection.Detailed = WeatherForecastDisplayModeSelection.Detailed == false;

            await WeatherForecastDisplayModeSelectionChanged.InvokeAsync(WeatherForecastDisplayModeSelection);
        }
    }
}