using MojangApi.Models;
using Newtonsoft.Json;
using Xunit;

namespace MojangApi.Tests
{
    public class PlayerProfileTests
    {
        [Fact]
        public void ParseProfileTest()
        {
            string json = "{\"id\":\"00992bb84f6949b990dc309476a1426b\",\"name\":\"chang196700\",\"properties\":[{\"name\":\"textures\",\"value\":\"eyJ0aW1lc3RhbXAiOjE1ODYyMjExNzY0NTMsInByb2ZpbGVJZCI6IjAwOTkyYmI4NGY2OTQ5Yjk5MGRjMzA5NDc2YTE0MjZiIiwicHJvZmlsZU5hbWUiOiJjaGFuZzE5NjcwMCIsInNpZ25hdHVyZVJlcXVpcmVkIjp0cnVlLCJ0ZXh0dXJlcyI6eyJTS0lOIjp7InVybCI6Imh0dHA6Ly90ZXh0dXJlcy5taW5lY3JhZnQubmV0L3RleHR1cmUvYjA3NDFjZGY3MjNlOWRiMjkxYTk4YzhmM2NjMGI0ZDExYzNmODQzYzMyN2FiMTVlMzBhNzViNGM3NmQzODEzNyIsIm1ldGFkYXRhIjp7Im1vZGVsIjoic2xpbSJ9fX19\",\"signature\":\"lEewNyiYkiFaTeYNZrcfsmh268nEPY/KsWWS2dmutgxmRAg2ftBmDhg/IyThlhL/qgyeqGYv3wh3P6xpQMkqgCsmVsXnamUQkg6OW5n8HeyZLnJ+OEAjHwYPl4M8s9IKSR+p1uyWWVfTJ4UGf+zs4dePiWYfEmSKHKO3CCYrQm6Ai/S02AnHad1dd+pPcl8oVNAEEgIkeheK8pdfY8eX9NdMN1Ezi0GLPPe5lLC10gWRhv5zDn++vsXFmdZoGJoflJptz3x01+w/b3Hbw1evbyk8A85KN1TvVbEnzwQng96mI6Ma49n0R3vxDRcg7ioRs4bO4rsm9iPaQRVBFlQbugd1y9FjDsgAXHgGqlklGL2aS5MdAc+oNVXlmnUqTB6Y+1fwYzbCHnEhzYbIgnA5pPas3V0Cq3ufFMwwLcTH4XlfaeH5sy0DaguWPEaNXReYIZJEoupbC3SemudrThogUJVAyl4oJ3EWcTg6Rx7GAghkNNmkIVALvbe8js/a1e23SdU5uiHKG0Vw6vZaQnXnUtEStpkqvCMKgzueB1hnAucLwg9PDlom6TPeBy/YDVUzacRbXRphehZZPhbN24N8fGKjW3vgKLtLraP1YJuYweTRpYAdOYq6OrtaEfDMLYqgRT+nk86XmaA/guavc3J50/Eh0pIxJR8L0dSa3Xyo3z4=\"}]}";
            var raw = JsonConvert.DeserializeObject<RawPlayerProfile>(json);
            var profile = new PlayerProfile(raw);
            System.Console.WriteLine(JsonConvert.SerializeObject(profile));
        }
    }
}
