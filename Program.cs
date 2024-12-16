using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Travis Scott");
        LinqFilter.ExibirMusicasComTonalidade(musicas, "C#");
        


        //var musicasPreferidasDoNicholas = new MusicasPreferidas("Nicholas");
        //musicasPreferidasDoNicholas.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoNicholas.AdicionarMusicasFavoritas(musicas[989]);
        //musicasPreferidasDoNicholas.AdicionarMusicasFavoritas(musicas[1234]);
        //musicasPreferidasDoNicholas.AdicionarMusicasFavoritas(musicas[456]);
        //musicasPreferidasDoNicholas.AdicionarMusicasFavoritas(musicas[4]);


        //var musicasPreferidasDaMirella = new MusicasPreferidas("Mirella");

        //musicasPreferidasDaMirella.AdicionarMusicasFavoritas(musicas[5]);
        //musicasPreferidasDaMirella.AdicionarMusicasFavoritas(musicas[1954]);
        //musicasPreferidasDaMirella.AdicionarMusicasFavoritas(musicas[1000]);
        //musicasPreferidasDaMirella.AdicionarMusicasFavoritas(musicas[95]);
        //musicasPreferidasDaMirella.AdicionarMusicasFavoritas(musicas[800]);

        //musicasPreferidasDaMirella.ExibirMusicasFavoritas();

        //musicasPreferidasDaMirella.GerarArquivoJson();




    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}