using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

namespace Examples
{
    public class Examples
    {
        [Fact]
        public async Task FetchingDxes()
        {
            // nie chciało gadać ponieważ jak się dogrzebałem to .net używa domyślnie tylko tls 
            // dopiero włączenie tls12 pomogło

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var client = new HttpClient
            {
                BaseAddress = new Uri("https://www.dxcluster.co.uk/")
            };
            var result = await client.GetAsync("index.php?/api/all");

            // await tutaj i async Task w nagłówku to jest mechanizm do obsługi asynchroniczności w .net
            // czyli ReadAsStringAsync może być wywołane w innym wątku, dlatego trzeba zrobić await 
            // żeby poczekać na dane
            var json = await result.Content.ReadAsStringAsync();
            var dx = JsonConvert.DeserializeObject<IEnumerable<DxSpot>>(json);

            // deserializujemy i w dx mamy obiekty i teraz można się pobawić z LINQ


            // filtrowanie tylko po jakims warunku
            var fromGermany = dx.Where(d => d.dx_name.Contains("GERMANY"));
            var fromPoland = dx.Where(d => d.dx_name.Contains("POLAND"));

            //  grupowanie jak w sqlu 
            var topCountries = dx.GroupBy(d => d.dx_name);

            fromGermany.Should().NotBeNull();
            fromPoland.Should().NotBeNull();
            topCountries.Should().NotBeEmpty();
        }
    }
}
